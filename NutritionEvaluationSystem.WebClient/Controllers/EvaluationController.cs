using Microsoft.AspNet.Identity;
using NutritionEvaluationSystem.WebClient.Models;
using NutritionEvaluationSystem.WebClient.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NutritionEvaluationSystem.WebClient.Controllers
{
    [Authorize]
    public class EvaluationController : Controller
    {
        private readonly ApplicationDbContext applicationDbContext;
        public EvaluationController() {
            applicationDbContext = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Create() {
            string userId = User.Identity.GetUserId();
            var loggedUser = applicationDbContext.Users.Single(user => user.Id == userId);
            var facilityArName = applicationDbContext.Facilities.FirstOrDefault(faciltiy => faciltiy.Id == loggedUser.FacilityId).ArName;

            var createEvaluationViewModel = new CreateEvaluationViewModel() {
                Questions = applicationDbContext.Questions.
                        OrderBy(question => question.Index).ToList(),
                FacilityName = facilityArName,
                LoggedUserName = loggedUser.UserName,
                Months = applicationDbContext.Months.ToList(),
                Years = new[] { DateTime.Now.Year, DateTime.Now.AddYears(-1).Year }
            };

            return View(createEvaluationViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateEvaluationViewModel createEvaluationViewModel) {
            if (!ModelState.IsValid)
                return View();

            createEvaluationViewModel.Questions = applicationDbContext.Questions.OrderBy(e => e.Index).ToList();
            var userId = User.Identity.GetUserId();

            var item = applicationDbContext.Evaluation.Add(new Models.Form.Evaluation() {
                Suggestions = string.IsNullOrEmpty(createEvaluationViewModel.Suggestions) ? null : createEvaluationViewModel.Suggestions,
                MonthId = createEvaluationViewModel.Month,
                EvaluateYear = createEvaluationViewModel.Year.ToString(),
                UserId = userId
            });
            applicationDbContext.SaveChanges();


            for (int i = 0; i < createEvaluationViewModel.AnswersIds.Count; i++) {
                applicationDbContext.EvaluationResult.Add(new EvaluationResult() {
                    QuestionId = createEvaluationViewModel.Questions[i].Id,
                    AnswerId = int.Parse(createEvaluationViewModel.AnswersIds[i]),
                    EvaluationId = item.Id
                });
            }

            applicationDbContext.SaveChanges();

            return RedirectToAction("EvaluationCreated");
        }

        public ActionResult EvaluationCreated() {
            return View();
        }
    }
}
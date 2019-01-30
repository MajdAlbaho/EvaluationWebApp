namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createMonths : DbMigration
    {
        public override void Up() {
            Sql("insert into common.months (EnName, ArName) values" +
                "('January',N'ﬂ«‰Ê‰ «·À«‰Ì'),('February',N'‘»«ÿ'),('March',N'¬–«—'),('April',N'‰Ì”«‰'),('May',N'√Ì«—')," +
                "('June',N'Õ“Ì—«‰'),('July',N' „Ê“'),('Aughst',N'¬»')," +
                "('Septemper',N'«Ì·Ê·'),('October',N' ‘—Ì‰ «·«Ê·'),('November',N' ‘—Ì‰ «·À«‰Ì'),('December',N'ﬂ«‰Ê‰ «·«Ê·')");
        }

        public override void Down() {
            Sql("delete from common.months");
        }
    }
}

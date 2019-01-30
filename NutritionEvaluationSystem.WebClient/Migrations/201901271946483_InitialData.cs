namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialData : DbMigration
    {
        public override void Up() {
            Sql("SET IDENTITY_INSERT Form.Questions ON " +
                "INSERT INTO Form.Questions(Id,EnQuestion,ArQuestion,[Index]) VALUES" +
                "(0, 'Is this your first visit to a nutrition clinic or a health center for the Red Crescent?', N'Â· Â–Â √Ê· “Ì«—… ·ﬂ ·⁄Ì«œ… «· €–Ì… √Ê „—ﬂ“ ’ÕÌ ··Â·«· «·√Õ„—ø', 0)," +
                "(1, 'How did you know about the services of the Syrian Red Crescent?', N'ﬂÌ› ⁄·„  »Œœ„«  «·Â·«· «·√Õ„— «·”Ê—Ìø', 1), " +
                "(2, 'How you can describe the service provided to you or your child today at the nutrition clinic?', N'ﬂÌ› Ì„ﬂ‰ﬂ √‰  ’› «·Œœ„… «·„ﬁœ„… ·ﬂ √Ê ·ÿ›·ﬂ «·ÌÊ„ ›Ì ⁄Ì«œ… «· €–Ì…ø', 2 ), " +
                "(4, 'Have you been treated by the staff in the clinic in a decent and gentle manner?', N'Â·  „  „⁄«„· ﬂ „‰ ﬁ»· «·⁄«„·Ì‰ ›Ì «·⁄Ì«œ… »‘ﬂ· ·«∆ﬁ Ê·ÿÌ›ø', 3 ), " +
                "(5, 'Did the doctor and nutritionist spend enough time for you and your child during the visit?', N'Â· √„÷Ï «·ÿ»Ì» Ê√Œ’«∆Ì «· €–Ì… «·Êﬁ  «·ﬂ«›Ì ·ﬂ Ê·ÿ›·ﬂ √À‰«¡ «·“Ì«—…ø', 4 ), " +
                "(6, 'Have you received any medicines or nutritional supplements?', N'Â· «” ·„  √Ì √œÊÌ… √Ê „ „„«  €–«∆Ì…ø', 5 ), " +
                "(7, 'Was the information provided to you by the nutrition team clear and understandable?', N'Â· ﬂ«‰  «·„⁄·Ê„«  «·„ﬁœ„… ·ﬂ „‰ ﬁ»· ›—Ìﬁ «· €–Ì… Ê«÷Õ… Ê„›ÂÊ„…ø', 6 ), " +
                "(8, 'Your suggestions', N'≈ﬁ —«Õ« ﬂ', 7 )" +
                "SET IDENTITY_INSERT Form.Questions OFF");

            Sql("SET IDENTITY_INSERT Form.Answers ON " +
                "INSERT INTO Form.Answers(Id, EnAnswer, ArAnswer) VALUES" +
                "(0, 'Yes', N'‰⁄„')," +
                "(1, 'No', N'·«'), " +
                "(2, 'Red Crescent Center', N'„—ﬂ“ «·Â·«· «·√Õ„—' ), " +
                "(3, 'Red Crescent volunteers', N'„ ÿÊ⁄Ì «·Â·«· «·√Õ„—' ), " +
                "(4, 'Local committee for the Red Crescent', N'·Ã‰… „Õ·Ì… ··Â·«· «·√Õ„—' ), " +
                "(5, 'Social media', N'Ê”«∆· «· Ê«’· «·«Ã „«⁄Ì' ), " +
                "(6, 'Relatives or friends', N'√ﬁ—»«¡ «Ê √’œﬁ«¡' ), " +
                "(7, 'Publications or video advertising', N'„ÿ»Ê⁄«  «Ê ≈⁄·«‰ „—∆Ì' ), " +
                "(8, 'Other / Please provide source', N'€Ì— –·ﬂ / «·—Ã«¡ –ﬂ— «·„’œ—' ), " +
                "(9, 'Bad', N'”Ì∆…' ), (10, 'Medium', N'„ Ê”ÿ…' ), " +
                "(11, 'Good', N'ÃÌœ…' ), " +
                "(12, 'Very good', N'ÃÌœ… Ãœ«' ), " +
                "(13, 'Excellent', N'„„ «“…' ), " +
                "(14, 'Sometimes', N'»⁄÷ «·√ÕÌ«‰' ), " +
                "(15, 'Not sure', N'·”  „ √ﬂœ' ), " +
                "(16, 'No, Unclear', N'·« €Ì— Ê«÷Õ…' ), " +
                "(17, 'Sometimes clear', N'»⁄÷ «·√ÕÌ«‰ Ê«÷Õ…' ), " +
                "(18, 'Yes, Clear', N'‰⁄„ Ê«÷Õ…' )" +
                "SET IDENTITY_INSERT Form.Answers OFF");
        }

        public override void Down() {
            Sql("delete from Form.Questions");
            Sql("delete from Form.Answers");
        }
    }
}

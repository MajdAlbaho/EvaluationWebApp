namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class InitialData : DbMigration
    {
        public override void Up() {
            Sql("SET IDENTITY_INSERT Form.Questions ON " +
                "INSERT INTO Form.Questions(Id,EnQuestion,ArQuestion,[Index]) VALUES" +
                "(0, 'Is this your first visit to a nutrition clinic or a health center for the Red Crescent?', N'�� ��� ��� ����� �� ������ ������� �� ���� ��� ������ �����ѿ', 0)," +
                "(1, 'How did you know about the services of the Syrian Red Crescent?', N'��� ���� ������ ������ ������ ������', 1), " +
                "(2, 'How you can describe the service provided to you or your child today at the nutrition clinic?', N'��� ����� �� ��� ������ ������� �� �� ����� ����� �� ����� ������ɿ', 2 ), " +
                "(4, 'Have you been treated by the staff in the clinic in a decent and gentle manner?', N'�� ��� ������� �� ��� �������� �� ������� ���� ���� ����ݿ', 3 ), " +
                "(5, 'Did the doctor and nutritionist spend enough time for you and your child during the visit?', N'�� ���� ������ ������� ������� ����� ������ �� ������ ����� ������ɿ', 4 ), " +
                "(6, 'Have you received any medicines or nutritional supplements?', N'�� ������ �� ����� �� ������ �����ɿ', 5 ), " +
                "(7, 'Was the information provided to you by the nutrition team clear and understandable?', N'�� ���� ��������� ������� �� �� ��� ���� ������� ����� ������ɿ', 6 ), " +
                "(8, 'Your suggestions', N'���������', 7 )" +
                "SET IDENTITY_INSERT Form.Questions OFF");

            Sql("SET IDENTITY_INSERT Form.Answers ON " +
                "INSERT INTO Form.Answers(Id, EnAnswer, ArAnswer) VALUES" +
                "(0, 'Yes', N'���')," +
                "(1, 'No', N'��'), " +
                "(2, 'Red Crescent Center', N'���� ������ ������' ), " +
                "(3, 'Red Crescent volunteers', N'������ ������ ������' ), " +
                "(4, 'Local committee for the Red Crescent', N'���� ����� ������ ������' ), " +
                "(5, 'Social media', N'����� ������� ���������' ), " +
                "(6, 'Relatives or friends', N'������ �� ������' ), " +
                "(7, 'Publications or video advertising', N'������� �� ����� ����' ), " +
                "(8, 'Other / Please provide source', N'��� ��� / ������ ��� ������' ), " +
                "(9, 'Bad', N'����' ), (10, 'Medium', N'������' ), " +
                "(11, 'Good', N'����' ), " +
                "(12, 'Very good', N'���� ���' ), " +
                "(13, 'Excellent', N'������' ), " +
                "(14, 'Sometimes', N'��� �������' ), " +
                "(15, 'Not sure', N'��� �����' ), " +
                "(16, 'No, Unclear', N'�� ��� �����' ), " +
                "(17, 'Sometimes clear', N'��� ������� �����' ), " +
                "(18, 'Yes, Clear', N'��� �����' )" +
                "SET IDENTITY_INSERT Form.Answers OFF");
        }

        public override void Down() {
            Sql("delete from Form.Questions");
            Sql("delete from Form.Answers");
        }
    }
}

namespace NutritionEvaluationSystem.WebClient.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class createMonths : DbMigration
    {
        public override void Up() {
            Sql("insert into common.months (EnName, ArName) values" +
                "('January',N'����� ������'),('February',N'����'),('March',N'����'),('April',N'�����'),('May',N'����')," +
                "('June',N'������'),('July',N'����'),('Aughst',N'��')," +
                "('Septemper',N'�����'),('October',N'����� �����'),('November',N'����� ������'),('December',N'����� �����')");
        }

        public override void Down() {
            Sql("delete from common.months");
        }
    }
}

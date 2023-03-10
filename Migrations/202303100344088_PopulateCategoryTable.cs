namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT CATEGORIES ON");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1,'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (2,'Maketing')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (3,'Business')");
        }
        
        public override void Down()
        {
        }
    }
}

namespace BraveLittleTodoList.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStatusSeedDataToDB : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Status (Name) VALUES ('To Do')");
            Sql("INSERT INTO Status (Name) VALUES ('In Progress')");
            Sql("INSERT INTO Status (Name) VALUES ('Done')");
        }
        
        public override void Down()
        {
            //You should add a way to roll back the migration
        }
    }
}

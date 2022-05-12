namespace DATA_FIRST_APPROCH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "mobile", c => c.String());
            AddColumn("dbo.Students", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Gender");
            DropColumn("dbo.Students", "mobile");
        }
    }
}

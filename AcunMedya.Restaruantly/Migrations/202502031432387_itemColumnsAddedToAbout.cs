namespace AcunMedya.Restaruantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class itemColumnsAddedToAbout : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Abouts", "Fitem", c => c.String());
            AddColumn("dbo.Abouts", "Sitem", c => c.String());
            AddColumn("dbo.Abouts", "Titem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Abouts", "Titem");
            DropColumn("dbo.Abouts", "Sitem");
            DropColumn("dbo.Abouts", "Fitem");
        }
    }
}

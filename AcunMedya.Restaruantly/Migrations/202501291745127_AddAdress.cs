namespace AcunMedya.Restaruantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAdress : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Adresses",
                c => new
                    {
                        AdressId = c.Int(nullable: false, identity: true),
                        Location = c.String(),
                        OpenHours = c.String(),
                        Email = c.String(),
                        Call = c.String(),
                    })
                .PrimaryKey(t => t.AdressId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Adresses");
        }
    }
}

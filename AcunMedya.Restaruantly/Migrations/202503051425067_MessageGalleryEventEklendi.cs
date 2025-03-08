namespace AcunMedya.Restaruantly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MessageGalleryEventEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        Description2 = c.String(),
                        Price = c.String(),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Galleries",
                c => new
                    {
                        GalleryId = c.Int(nullable: false, identity: true),
                        ImageUrl = c.String(),
                    })
                .PrimaryKey(t => t.GalleryId);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Sender = c.String(),
                        Receiver = c.String(),
                        Content = c.String(),
                        Time = c.DateTime(nullable: false),
                        IsRead = c.String(),
                    })
                .PrimaryKey(t => t.MessageId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Messages");
            DropTable("dbo.Galleries");
            DropTable("dbo.Events");
        }
    }
}

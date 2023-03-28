namespace ContactManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PhoneNumber", "Contact_Id", "dbo.Contact");
            DropIndex("dbo.PhoneNumber", new[] { "Contact_Id" });
            RenameColumn(table: "dbo.PhoneNumber", name: "Contact_Id", newName: "ContactId");
            AlterColumn("dbo.PhoneNumber", "ContactId", c => c.Int(nullable: false));
            CreateIndex("dbo.PhoneNumber", "ContactId");
            AddForeignKey("dbo.PhoneNumber", "ContactId", "dbo.Contact", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PhoneNumber", "ContactId", "dbo.Contact");
            DropIndex("dbo.PhoneNumber", new[] { "ContactId" });
            AlterColumn("dbo.PhoneNumber", "ContactId", c => c.Int());
            RenameColumn(table: "dbo.PhoneNumber", name: "ContactId", newName: "Contact_Id");
            CreateIndex("dbo.PhoneNumber", "Contact_Id");
            AddForeignKey("dbo.PhoneNumber", "Contact_Id", "dbo.Contact", "Id");
        }
    }
}

namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Contents", "WriterID", c => c.Int());
            // CreateIndex("dbo.Contents", "WriterID");
            // AddForeignKey("dbo.Contents", "WriterID", "dbo.Writers", "WriterID");

            AddColumn("dbo.Writers", "WriterAbout", c => c.String(maxLength: 100));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 200));
            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            //DropIndex("dbo.Contents", new[] { "WriterID" });
            // DropColumn("dbo.Contents", "WriterID");

            AlterColumn("dbo.Writers", "WriterPassword", c => c.String(maxLength: 20));
            AlterColumn("dbo.Writers", "WriterMail", c => c.String(maxLength: 50));
            DropColumn("dbo.Writers", "WriterAbout");

        }
    }
}

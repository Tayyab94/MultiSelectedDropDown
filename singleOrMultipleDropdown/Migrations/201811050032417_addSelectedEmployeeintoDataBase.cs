namespace singleOrMultipleDropdown.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addSelectedEmployeeintoDataBase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SelectedEmployees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SelectedEmployeeID = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SelectedEmployees");
        }
    }
}

namespace CodeFirst_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateKategoriDetayColumnInKategorisTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Kategoris", "KategoriDetay");
        }
    }
}

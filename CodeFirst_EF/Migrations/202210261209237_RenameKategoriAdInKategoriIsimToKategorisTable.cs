namespace CodeFirst_EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameKategoriAdInKategoriIsimToKategorisTable : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriID" });
            AddColumn("dbo.Kategoris", "KategoriAd", c => c.String());
            CreateIndex("dbo.Urunlers", "Kategori_KategoriId");
            DropColumn("dbo.Kategoris", "KategoriDetay");
            DropColumn("dbo.Kategoris", "KategoriIsim");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Kategoris", "KategoriIsim", c => c.String());
            AddColumn("dbo.Kategoris", "KategoriDetay", c => c.String());
            DropIndex("dbo.Urunlers", new[] { "Kategori_KategoriId" });
            DropColumn("dbo.Kategoris", "KategoriAd");
            CreateIndex("dbo.Urunlers", "Kategori_KategoriID");
        }
    }
}

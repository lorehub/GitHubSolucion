namespace GitHubEjemplo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioEstructuraPublicacion : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Publicacions", newName: "Publicacion");
            AlterColumn("dbo.Publicacion", "Usuario", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Publicacion", "Descripcion", c => c.String(maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Publicacion", "Descripcion", c => c.String());
            AlterColumn("dbo.Publicacion", "Usuario", c => c.String());
            RenameTable(name: "dbo.Publicacion", newName: "Publicacions");
        }
    }
}

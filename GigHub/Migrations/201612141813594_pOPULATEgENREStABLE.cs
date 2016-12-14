namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pOPULATEgENREStABLE : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres(Id, Name) VALUES(1, 'Jazz')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(2, 'Blues')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(3, 'Rap')");
            Sql("INSERT INTO Genres(Id, Name) VALUES(4, 'Rock')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE Id (1,2,3,4");
        }
    }
}

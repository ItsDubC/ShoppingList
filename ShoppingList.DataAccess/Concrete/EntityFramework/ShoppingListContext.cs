using ShoppingListApp.Entities.Concrete;
using System;
using System.Data.Entity;
using System.Linq;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public class ShoppingListContext : DbContext
    {
        // Your context has been configured to use a 'ShoppingListContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ShoppingList.DataAccess.Concrete.EntityFramework.ShoppingListContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ShoppingListContext' 
        // connection string in the application configuration file.
        public ShoppingListContext()
            : base("name=ShoppingListContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public DbSet<ShoppingList> ShoppingLists { get; set; }
        public DbSet<ListEntry> Entries { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}
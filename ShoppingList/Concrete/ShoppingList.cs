using ShoppingListApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Entities.Concrete
{
    public class ShoppingList : IEntity
    {
        public ShoppingList()
        {
            Entries = new List<ListEntry>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ListEntry> Entries { get; set; }
    }
}

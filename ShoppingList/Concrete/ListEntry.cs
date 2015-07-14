using ShoppingListApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Entities.Concrete
{
    public class ListEntry : IEntity
    {
        public int Id { get; set; }
        public string ItemDescription { get; set; }
        public int Quantity { get; set; }
        public int ShoppingListId { get; set; }
    }
}

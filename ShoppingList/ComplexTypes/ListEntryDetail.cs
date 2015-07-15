using ShoppingListApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.Entities.ComplexTypes
{
    public class ListEntryDetail : IEntity
    {
        public int ListEntryId { get; set; }
        public string ListEntryItemDescription { get; set; }
        public int ListEntryQuantity { get; set; }
        public string ShoppingListName { get; set; }
    }
}

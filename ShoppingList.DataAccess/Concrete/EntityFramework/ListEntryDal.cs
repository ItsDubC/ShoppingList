using ShoppingListApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public class ListEntryDal : EfRepositoryBase<ListEntry, ShoppingListContext>
    {
        public List<ListEntry> GetAllEntriesForList(int listId)
        {
            using (var context = new ShoppingListContext())
            {
                return context.Entries.Where(t => t.ShoppingListId == listId).ToList();
            }
        }
    }
}

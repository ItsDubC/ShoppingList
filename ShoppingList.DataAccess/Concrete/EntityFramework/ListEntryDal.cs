using ShoppingListApp.DataAccess.Abstract;
using ShoppingListApp.DataAccess.Concrete.EntityFramework.Contexts;
using ShoppingListApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities.ComplexTypes;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public class ListEntryDal : EfRepositoryBase<ListEntry, ShoppingListContext>, IListEntryDal
    {
        public List<ListEntry> GetAllEntriesForList(int listId)
        {
            using (var context = new ShoppingListContext())
            {
                return context.Entries.Where(t => t.ShoppingListId == listId).ToList();
            }
        }

        public List<ListEntryDetail> GetListEntryDetailsByShoppingListId(int shoppingListId)
        {
            //using (var context = new ShoppingListContext())
            //{
            //    return context.L
            //}
        }

        public int GetListEntryCountByShoppingListId(int shoppingListId)
        {
            using (var context = new ShoppingListContext())
            {
                return context.Entries.Where(t => t.ShoppingListId == shoppingListId).Count();
            }
        }
    }
}

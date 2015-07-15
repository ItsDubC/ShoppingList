using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities.Concrete;
using ShoppingListApp.DataAccess.Concrete.EntityFramework.Contexts;
using ShoppingListApp.DataAccess.Abstract;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public class ShoppingListDal : EfRepositoryBase<ShoppingList, ShoppingListContext>, IShoppingListDal
    {
        public List<ShoppingList> GetAllShoppingLists()
        {
            using (var context = new ShoppingListContext())
            {
                return context.ShoppingLists.ToList();
            }
        }
    }
}

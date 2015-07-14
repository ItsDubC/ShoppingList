using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingListApp.Entities.Concrete;

namespace ShoppingListApp.DataAccess.Concrete.EntityFramework
{
    public class ShoppingListDal : EfRepositoryBase<ShoppingList, ShoppingListContext>
    {
        List<ShoppingList> GetAllShoppingLists()
        {
            using (var context = new ShoppingListContext())
            {
                return context.ShoppingLists.ToList();
            }
        }
    }
}

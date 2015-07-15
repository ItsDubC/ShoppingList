using ShoppingListApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.DataAccess.Abstract
{
    public interface IShoppingListDal : IEntitityRepositoryBase<ShoppingList>
    {
        List<ShoppingList> GetAllShoppingLists();
    }
}

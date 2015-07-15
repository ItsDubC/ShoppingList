using ShoppingListApp.Entities.ComplexTypes;
using ShoppingListApp.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.DataAccess.Abstract
{
    public interface IListEntryDal : IEntitityRepositoryBase<ListEntry>
    {
        List<ListEntryDetail> GetListEntryDetailsByShoppingListId(int shoppingListId);

        int GetListEntryCountByShoppingListId(int shoppingListId);
    }
}

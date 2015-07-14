using ShoppingListApp.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingListApp.DataAccess.Abstract
{
    public interface IEntitityRepositoryBase<T> where T: IEntity, new()
    {
        void Add(T entity);
        T GetById(int id);
        void Update(T entity);
        void Delete(int id);
    }
}

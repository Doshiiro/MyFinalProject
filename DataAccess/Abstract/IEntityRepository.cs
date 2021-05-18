using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Class : Referans tip
    //IEntity: IEntity olabilir  veya IEntity impelemente eden  bir nesne olabilir
    //new : new'lenebilir olmalı yani interface new'lenemediği için IEntity kullanılamaz ama onu impelemente edenler kullanılabilir
  public  interface IEntityRepository<T> where T:class,IEntity
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T, bool>> filter );
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

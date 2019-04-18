using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abc.Core.DataAccess;
using Abc.Northwind.Entities.Concrete;

namespace Abc.Northwind.DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        //Custom Operations
    }
}

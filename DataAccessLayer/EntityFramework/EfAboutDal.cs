using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    //Todo İlerleyen derslerde CRUD işlemleri harici ayrı bir işlem gerçekleştirmek istediğimizde sadece ilgili entity'e özel bir özellik yazmak istersek buraya ekleyeceğiz.
    public class EfAboutDal : GenericRepository<About>,IAboutDal
    {
    }
}

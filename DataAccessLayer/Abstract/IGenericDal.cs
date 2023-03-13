using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>  where T:class
    {
        //todo üstteki Interface'imiz bütün methodları tutuyor.
        //Yani bütün sınıfların interface'i için method yazmamıza gerek yok.
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetList();
        T GetById(int id);
        
    }
}

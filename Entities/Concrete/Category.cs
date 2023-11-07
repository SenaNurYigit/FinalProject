using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category: IEntity
    {
        //Bu mimaride biz IEntity görünce bu classın bir veri tabanı tablosuna karşılık gelidiğini anlamış oluyoruz.
        //Category sınıfı IEntity sınıfından miras aldığı için IEntity sınıfı bu sınıfın referansını tutmuş oluyor.
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

    }
}

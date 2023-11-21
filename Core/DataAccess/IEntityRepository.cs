using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    //Generic constraint(kısıt)
    //Normalde T yazdığımız zaman oraya herhangi bir veri tipi de yazabiliriz. Bunu kısıtlamak mümkün. Mesela class:Referans tip olabilir demek oluyor.
    //Sadece class yazınca bu sefer herhangi bir class yazabilir. Bunun önüne geçmek ve bir veri tabanı nesnesi olmasını  sağlamak için bir sınırlama daha yapabiliriz.
    //IEntity yazmak; IEntity veya IEntity'i implemente eden bir nesne olabilir demek oluyor.
    //Sadece bu şartlar olduğunda IEntity nesnesini de T yerine yazabilir oluruz ama bizim istemediğimiz bir şey o. Biz direkt somut bir veri tabanı nesnesi verilmesini istiyoruz.
    //Bunun önüne geçmek inin new() yazıyoruz. Bu da new'lenebilir olsun demek oluyor. Interface'ler newlenemeyeceği için (somut bir nesne newlenebilir) artık onu yazamayız.

    public interface IEntityRepository<T> where T: class, IEntity, new()
    { 
        List<T > GetAll(Expression<Func<T,bool>> filter=null); // Bu satırda filter null da olabilir. Bu demek oluyor ki filtre verilmediyse tüm veriyi istiyor demektir.
        T Get(Expression<Func<T, bool>> filter); // Filtre zorunlu demek oluyor.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}

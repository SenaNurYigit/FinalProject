using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        //Bu constructor sayesinde ProductManager bir yerde new'lendiğinde bana bir tane IProductDal referansı gönder demiş oluyoruz. IProductDal nesenesi de bizim DataAccess katmanımızdaki Interface.
        //Böylece ilerde biz istediğimiz veri erişim metodunu kullanabiliyor olacağız.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //İş kodları
            return _productDal.GetAll();
        }
    }
}

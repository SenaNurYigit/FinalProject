using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService //Ben burdaki metotları servis ediyorum. O yüzden service diyoruz.
    {
        IDataResult<List<Product>> GetAll(); //Bizim hedefimiz hem datayı hem de resultı tutmak. O yüzden IDataResult diye bir interface tanımladık.
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);

    }
}

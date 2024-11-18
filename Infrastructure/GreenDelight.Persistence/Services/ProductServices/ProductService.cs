using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Apllication.Interfaces.UnitofWorks;
using GreenDelight.Application.Constants;
using GreenDelight.Application.Interfaces.Services.ProductServices;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IResult> AddAsync(ProductAddDto productAddDto)
        {

            var category = await _unitOfWork.GetGenericRepository<Category>()
                .GetAsync(c => c.Name == productAddDto.CategoryName);
            if (category == null)
            {
                return new ErrorResult("Kategori bulunamadı.");
            }
            var product = productAddDto.Adapt<Product>();
            product.CategoryID = category.ID;
            product.CreatedDate = DateTime.Now;
            await _unitOfWork.GetGenericRepository<Product>().AddAsync(product);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.ProductAdded);
        }

        public async Task<IDataResult<List<ProductDetailDto>>> GetAllAsync()
        {
            var products = await _unitOfWork.GetGenericRepository<Product>().GetAllAsync();

            if (products == null || !products.Any())
            {
                return new ErrorDataResult<List<ProductDetailDto>>("Ürün bulunamadı.");
            }

            var productDtos = products.Adapt<List<ProductDetailDto>>();

            return new SuccessDataResult<List<ProductDetailDto>>(productDtos,Messages.ProductsListed);
        }

        public Task<IDataResult<ProductDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}

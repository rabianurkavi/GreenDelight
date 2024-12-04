using GreenDelight.Apllication.DTOs.ProductDtos;
using GreenDelight.Apllication.Interfaces.UnitofWorks;
using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.CategoryDtos;
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

        public async Task<IDataResult<ProductDto>> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return new ErrorDataResult<ProductDto>("Geçersiz ürün ID.");
            }

            var product = await _unitOfWork.GetGenericRepository<Product>().GetAsync(x => x.ID == id);
            if (product == null)
            {
                return new ErrorDataResult<ProductDto>("Ürün bulunamadı.");
            }

            var productDto = product.Adapt<ProductDto>();
            return new SuccessDataResult<ProductDto>(productDto, Messages.ProductsListed);
        }

        public async Task<IResult> RemoveAsync(int id)
        {
            if (id <= 0)
            {
                return new ErrorResult("Geçersiz ürün ID.");
            }

            var product = await _unitOfWork.GetGenericRepository<Product>().GetAsync(x => x.ID == id);
            if (product == null)
            {
                return new ErrorResult("Silinecek ürün bulunamadı.");
            }

            await _unitOfWork.GetGenericRepository<Product>().DeleteAsync(product);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.ProductDeleted);
        }

        public async Task<IResult> UpdateAsync(ProductUpdateDto productUpdateDto)
        {
            if (productUpdateDto == null)
            {
                return new ErrorResult("Ürün bilgileri eksik.");
            }

            var product = await _unitOfWork.GetGenericRepository<Product>().GetAsync(x => x.ID == productUpdateDto.Id);
            if (product == null)
            {
                return new ErrorResult("Güncellenecek kategori bulunamadı.");
            }
            var productAdapt = productUpdateDto.Adapt(product);

            await _unitOfWork.GetGenericRepository<Product>().UpdateAsync(productAdapt);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}

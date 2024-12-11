using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Application.Interfaces.UnitofWorks;
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
using Microsoft.EntityFrameworkCore;

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
            var products = await _unitOfWork.GetGenericRepository<Product>().GetAllAsync(include: query => query.Include(a => a.Category), enableTracking: false);

            if (products == null || !products.Any())
            {
                return new ErrorDataResult<List<ProductDetailDto>>("Ürün bulunamadı.");
            }

            var productDtos = products.Adapt<List<ProductDetailDto>>();

            return new SuccessDataResult<List<ProductDetailDto>>(productDtos,Messages.ProductsListed);
        }

        public async Task<IDataResult<ProductDetailDto>> GetByIdAsync(int id)
        {
            if (id <= 0)
            {
                return new ErrorDataResult<ProductDetailDto>("Geçersiz ürün ID.");
            }

            var product = await _unitOfWork.GetGenericRepository<Product>().GetAsync(x => x.ID == id, include: query => query.Include(a => a.Category), enableTracking: false);
            if (product == null)
            {
                return new ErrorDataResult<ProductDetailDto>("Ürün bulunamadı.");
            }

            var productDto = product.Adapt<ProductDetailDto>();
            return new SuccessDataResult<ProductDetailDto>(productDto, Messages.ProductsListed);
        }

        public async Task<IDataResult<List<ProductDetailDto>>> ProductListByCategory(int categoryId)
        {
            var product=await _unitOfWork.GetGenericRepository<Product>().GetAllAsync(x=>x.CategoryID==categoryId, include: query => query.Include(a=>a.Category), enableTracking: false); 
            if(product.Count==0)
            {
                return new ErrorDataResult<List<ProductDetailDto>>("Bu kategoriye ait ürün bulunamadı.");
            }
            var productDto= product.Adapt<List<ProductDetailDto>>();
            return new SuccessDataResult<List<ProductDetailDto>>(productDto,Messages.ProductsListed); 
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

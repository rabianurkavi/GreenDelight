using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.CategoryDtos;
using GreenDelight.Application.Interfaces.Services.CategoryServices;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddAsync(CategoryAddDto categoryAddDto)
        {
            try
            {
                if (categoryAddDto == null)
                    return new ErrorResult("Kategori bilgileri eksik.");

                var category = categoryAddDto.Adapt<Category>();
                await _unitOfWork.GetGenericRepository<Category>().AddAsync(category);
                await _unitOfWork.CommitAsync();

                return new SuccessResult(Messages.CategoryAdded);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kategori eklenirken bir hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<List<CategoryDetailDto>>> GetAllAsync()
        {
            try
            {
                var categories = await _unitOfWork.GetGenericRepository<Category>().GetAllAsync();

                if (categories == null || !categories.Any())
                    return new ErrorDataResult<List<CategoryDetailDto>>("Kategori bulunamadı.");

                var categoriesDto = categories.Adapt<List<CategoryDetailDto>>();
                return new SuccessDataResult<List<CategoryDetailDto>>(categoriesDto, Messages.CategorysListed);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<List<CategoryDetailDto>>($"Kategoriler getirilirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IDataResult<CategoryDetailDto>> GetByIdAsync(int id)
        {
            try
            {
                if (id <= 0)
                    return new ErrorDataResult<CategoryDetailDto>("Geçersiz kategori ID.");

                var category = await _unitOfWork.GetGenericRepository<Category>().GetAsync(x => x.ID == id);
                if (category == null)
                    return new ErrorDataResult<CategoryDetailDto>("Kategori bulunamadı.");

                var categoryDto = category.Adapt<CategoryDetailDto>();
                return new SuccessDataResult<CategoryDetailDto>(categoryDto, Messages.CategorysListed);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<CategoryDetailDto>($"Kategori getirilirken bir hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> RemoveAsync(int id)
        {
            try
            {
                if (id <= 0)
                    return new ErrorResult("Geçersiz kategori ID.");

                var category = await _unitOfWork.GetGenericRepository<Category>().GetAsync(x => x.ID == id);
                if (category == null)
                    return new ErrorResult("Silinecek kategori bulunamadı.");

                await _unitOfWork.GetGenericRepository<Category>().DeleteAsync(category);
                await _unitOfWork.CommitAsync();

                return new SuccessResult(Messages.CategoryDeleted);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kategori silinirken hata oluştu: {ex.Message}");
            }
        }

        public async Task<IResult> UpdateAsync(CategoryDetailDto categoryDetailDto)
        {
            try
            {
                if (categoryDetailDto == null)
                    return new ErrorResult("Kategori bilgileri eksik.");

                var category = await _unitOfWork.GetGenericRepository<Category>().GetAsync(x => x.ID == categoryDetailDto.ID);
                if (category == null)
                    return new ErrorResult("Güncellenecek kategori bulunamadı.");

                category = categoryDetailDto.Adapt(category);
                await _unitOfWork.GetGenericRepository<Category>().UpdateAsync(category);
                await _unitOfWork.CommitAsync();

                return new SuccessResult(Messages.CategoryUpdated);
            }
            catch (Exception ex)
            {
                return new ErrorResult($"Kategori güncellenirken hata oluştu: {ex.Message}");
            }
        }
    }
}

using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.AuthDtos.LoginDtos;
using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Application.DTOs.UserDtos;
using GreenDelight.Application.Interfaces.Services.UserServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Application.Rules;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.UserServices
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly AuthRules _authRules;
        public UserService(IUnitOfWork unitOfWork, AuthRules authRules)
        {
            _unitOfWork = unitOfWork;
            _authRules = authRules;
        }
        public async Task<UserDto> TakeUserInformation(string userName)
        {
            var user= await _unitOfWork.GetGenericRepository<User>().GetAsync(x=>x.UserName == userName);

            var userDto=user.Adapt<UserDto>();

            return userDto;
        }

        public async Task<SuccessDataResult<UserDto>> TakeUserInfo(string username)
        {
            var user = await _unitOfWork.GetGenericRepository<User>().GetAsync(x => x.UserName == username);
            if (user == null)
                await _authRules.EmailAddressShouldBeValid(user);
            var userDto=user.Adapt<UserDto>();
            return new SuccessDataResult<UserDto>(userDto,Messages.UserTookInfo);
        }

        public async Task<IResult> UpdateProfile(UserDto userDto)
        {
            if (userDto == null)
                return new ErrorResult("Kullanıcı bilgileri eksik.");
            var user = await _unitOfWork.GetGenericRepository<User>().GetAsync(x => x.Id == userDto.ID);

            if (user == null)
                return new ErrorResult("Güncellenecek id ye ait kullanıcı bulunamadı.");
            var userAdapt = userDto.Adapt(user);
            await _unitOfWork.GetGenericRepository<User>().UpdateAsync(userAdapt);
            await _unitOfWork.CommitAsync();
            return new SuccessResult(Messages.UserUpdated);
        }
       
    }
}

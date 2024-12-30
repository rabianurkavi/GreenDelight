using GreenDelight.Application.Constants;
using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.Interfaces.Services.ContactServices;
using GreenDelight.Application.Interfaces.UnitofWorks;
using GreenDelight.Domain.Concrete;
using GreenDelight.Domain.Results;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Persistence.Services.ContactServices
{
    public class ContactService : IContactService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IResult> AddAsync(ContactDto contactDto)
        {
            var contact = contactDto.Adapt<Contact>();

            await _unitOfWork.GetGenericRepository<Contact>().AddAsync(contact);
            await _unitOfWork.CommitAsync();

            return new SuccessResult(Messages.ContactAdded);
        }
    }
}

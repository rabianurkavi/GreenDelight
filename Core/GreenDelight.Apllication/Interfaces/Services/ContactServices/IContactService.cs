using GreenDelight.Application.DTOs.ContactDtos;
using GreenDelight.Application.DTOs.ProductDtos;
using GreenDelight.Domain.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.Interfaces.Services.ContactServices
{
    public interface IContactService
    {
        Task<IResult> AddAsync(ContactDto contactDto);
    }
}

using GreenDelight.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.CommentDtos
{
    public class CommentAddDto
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string CommentDescription { get; set; }
    }
}

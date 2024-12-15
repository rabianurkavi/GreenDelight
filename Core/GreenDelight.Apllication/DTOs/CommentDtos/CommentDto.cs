using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Application.DTOs.CommentDtos
{
    public class CommentDto
    {
        public int ProductId { get; set; }
        public string UserName { get; set; }
        public string UserImageUrl { get; set; }
        public string CommentDescription { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

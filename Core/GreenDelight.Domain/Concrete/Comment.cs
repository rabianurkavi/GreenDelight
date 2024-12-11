using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class Comment:AuditableEntity
    {
        public Guid UserId { get; set; }
        public int ProductId { get; set; }
        public string CommentDescription { get; set; }
        public virtual User User { get; set; }
        public virtual Product Product { get; set; }

    }
}

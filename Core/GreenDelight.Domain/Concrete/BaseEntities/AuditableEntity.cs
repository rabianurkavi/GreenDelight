using GreenDelight.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.BaseEntities
{
    public class AuditableEntity : BaseEntity, ICreatedEntity, IUpdatedEntity
    {
        public int CreatedId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedId { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

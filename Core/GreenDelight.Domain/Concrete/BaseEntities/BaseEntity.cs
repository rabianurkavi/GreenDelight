using GreenDelight.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.BaseEntities
{
    public class BaseEntity : IEntityBase
    {
        [Key]
        public int ID { get; set; }
    }
}

using GreenDelight.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete.BaseEntities
{
    public class BaseEntity : IEntityBase
    {
        public int ID { get; set; }
    }
}

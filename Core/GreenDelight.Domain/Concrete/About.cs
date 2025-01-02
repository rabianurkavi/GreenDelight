using GreenDelight.Domain.Concrete.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Concrete
{
    public class About : AuditableEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageFile { get; set; }
        public bool Status { get; set; }

    }
}

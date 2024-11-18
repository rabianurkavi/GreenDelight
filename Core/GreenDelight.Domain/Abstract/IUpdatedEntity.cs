using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Abstract
{
    public interface IUpdatedEntity
    {
        public DateTime? UpdatedDate { get; set; }
    }
}

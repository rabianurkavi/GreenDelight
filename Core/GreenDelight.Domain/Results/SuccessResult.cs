using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenDelight.Domain.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(true, message)
        {
            //Sadece mesaj
        }
        public SuccessResult() : base(true)
        {

        }
    }
}

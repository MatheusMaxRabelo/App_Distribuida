using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GettingReady.Validation
{
    public class DiferenteDeZero : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return Convert.ToInt32(value) == 0 ? false : true;
        }
    }
}

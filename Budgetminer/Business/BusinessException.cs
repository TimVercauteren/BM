using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Budgetminer
{
    public class BusinessException : Exception
    {
        public BusinessException(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public string ErrorMessage { get; set; }
    }
}

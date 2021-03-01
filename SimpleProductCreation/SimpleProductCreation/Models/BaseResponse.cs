using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleProductCreation.Models
{
    public class BaseResponse<T>
    {
        public T data;
        public List<T> dataList;
        public bool status;
        public string errorMessage;
        public BaseResponse()
        {

        }
    }
}

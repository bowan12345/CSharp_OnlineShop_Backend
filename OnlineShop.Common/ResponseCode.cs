using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Common
{
    public enum ResponseCode
    {
        Success = 200,

        Error = 400,

        Unauthorized = 401,

        Forbidden = 403,

        NotFound = 404,

        InternalServerError = 500,

        ParameterError = 1000,

    }
}

namespace OnlineShop.Common
{
    public class ApiResult<T>
    {
        public ResponseCode ResponseCode { get; set; }

        public T Data { get; set; }

        public string Message { get; set; }

        public ApiResult()
        {
            ResponseCode = ResponseCode.Success;
            Message = "success";
        }

        public static ApiResult<T> Success(T data)
        {
            return new ApiResult<T> { Data = data, Message = "Success", ResponseCode = ResponseCode.Success };
        }

/*        public static ApiResult<T> Error(T data, string message = "Error", ResponseCode responseCode = ResponseCode.Error)
        {
            return new ApiResult<T> { Data = data, Message = message, ResponseCode = responseCode };
        }*/

        /// <summary>
        /// Failed, a failed message need to be define
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <param name="responseCode"></param>
        /// <returns></returns>
        public static ApiResult<T> Failed(T data, string message)
        {
            return new ApiResult<T> { Data = data, Message = message, ResponseCode = ResponseCode.Error };
        }

        public static ApiResult<T> NotFound(T data)
        {
            return new ApiResult<T> { Data = data, Message = "NotFound", ResponseCode = ResponseCode.NotFound };
        }

        public static ApiResult<T> ParameterError(T data)
        {
            return new ApiResult<T> { Data = data, Message = "ParameterError", ResponseCode = ResponseCode.ParameterError };
        }

        public static ApiResult<T> Unauthorized(T data)
        {
            return new ApiResult<T> { Data = data, Message = "Unauthorized", ResponseCode = ResponseCode.Unauthorized };
        }

    }
}

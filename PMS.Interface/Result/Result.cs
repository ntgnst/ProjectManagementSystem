namespace PMS.Interface.Result
{
    public class Result<T> : IResult<T>
    {
        public bool IsSuccess { get; set; }

        public ResultTypeEnum ResultType { get; set; }

        public string Message { get; set; }

        public string ErrorCode { get; set; }

        public T Data { get; set; }

        public Result()
        {
            Data = default(T);
        }

        public Result(bool IsSuccess, ResultTypeEnum ResultType, string Message, params string[] parameters)
            : this(IsSuccess, string.Empty, ResultType, default(T), Message, parameters)
        {

        }
        public Result(T Data, string Message)
            : this(true, ResultTypeEnum.Information, Data, Message, string.Empty)
        {

        }

        public Result(T Data)
            : this(true, ResultTypeEnum.None, Data, string.Empty, string.Empty)
        {
        }

        public Result(bool IsSuccess, string ErrorCode, ResultTypeEnum ResultType, string Message, params string[] parameters)
            : this(IsSuccess, ErrorCode, ResultType, default(T), Message, parameters)
        {

        }

        public Result(bool IsSuccess, ResultTypeEnum ResultType, T Data, string Message, params string[] parameters)
            : this(IsSuccess, string.Empty, ResultType, Data, Message, parameters)
        {

        }

        public Result(bool IsSuccess, string ErrorCode, ResultTypeEnum ResultType, T Data, string Message, params string[] parameters)
        {
            this.IsSuccess = IsSuccess;
            this.ResultType = ResultType;
            this.Message = string.Format(Message, parameters);
            this.ErrorCode = ErrorCode;
            this.Data = Data;
        }

        public void Import(IResult result)
        {
            this.IsSuccess = result.IsSuccess;
            this.ResultType = result.ResultType;
            this.Message = result.Message;
        }
    }
}

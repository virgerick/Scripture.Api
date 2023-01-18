namespace Scripture.Api.Models
{
    public interface IResult
    {
        public bool Succeeded { get; set; }
        public string[]? Messages { get; set; }
    }
    public interface IResult<T> : IResult
    {
        public T? Data { get; set; }
    }
    public interface IResultList<T> : IResult
    {
        public IList<T>? Items { get; set; }
    }

    public class Result : IResult
    {
        public bool Succeeded { get; set; }
        public string[] Messages { get; set; }
        public Result(bool succeded, string[] messages)
        {
            Succeeded = succeded;
            Messages = messages;
        }

        public static Result Failure(string[] messages = default) => new Result(false, messages);
        public static Result Success(string[] messages = default) => new Result(true, messages);

    }
    public class Result<T> : IResult<T>
    {
        public bool Succeeded { get; set; }
        public string[] Messages { get; set; }
        public T? Data { get; set; }
        public Result(bool succeded, T data, string[] messages)
        {
            Succeeded = succeded;
            Data = data;
            Messages = messages;
        }

        public static Result<T> Failure(string[] messages = default, T data = default) => new Result<T>(false, data, messages);
        public static Result<T> Success(T data = default, string[] messages = default) => new Result<T>(true, data, messages);
    }
    public class ResultList<T> : IResultList<T>
    {
        public bool Succeeded { get; set; }
        public string[]? Messages { get; set; }
        public IList<T>? Items { get; set; }
        public ResultList(bool succeded, string[] messages, IList<T> items)
        {
            Succeeded = succeded;
            Messages = messages;
            Items = items;
        }
        public static ResultList<T> Failure(string[] messages = default,List<T> data = default) => new ResultList<T>(false,messages,data);
        public static ResultList<T> Success(List<T> data = default, string[] messages = default) => new ResultList<T>(true,  messages,data);
    }
}

namespace dotnet.Common.ErrorHandling
{
    public class Response<T>
    {
        public bool IsSuccess { get; }

        public T Data { get;}

        public Response(T data)
        {
            IsSuccess = true;
            Data = data;
        }
    }
}
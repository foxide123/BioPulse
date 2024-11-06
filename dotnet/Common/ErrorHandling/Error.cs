namespace dotnet.Common.ErrorHandling
{
    public class Error
    {

        public string ErrorMessage{ get; }
        public Error(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }
    }

    public class I2cError : Error
    {
        public I2cError(string errorMessage) 
            : base(errorMessage)
        {
        }
    }
}
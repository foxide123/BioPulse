namespace dotnet.Common.Error
{
    public abstract class Failure
    {
        string message;
        Failure(message){
            this.message = message;
        }
    }

    class ServerFailure : Failure
    {
        ServerFailure(message){
            super(message);
        }
    }
}
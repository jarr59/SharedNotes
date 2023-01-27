namespace ShareNotes.Exceptions
{
    public class ClientException : BaseException
    {

        public ClientException(ClientExceptionType clientExceptionType) : base(HttpErrorCode.BadRequest)

        {
            ClientExceptionType = clientExceptionType;
        }

        public ClientExceptionType ClientExceptionType { get; }
    }
    public enum ClientExceptionType
    {
        LengthFieldInvalid = 0,
        RequiredField = 1
    }
}

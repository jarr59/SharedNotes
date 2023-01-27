namespace ShareNotes.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException(ClientExceptionType clientExceptionType) : base(HttpErrorCode.BadRequest)

    {
        ClientExceptionType = clientExceptionType;
    }

    public ClientExceptionType ClientExceptionType { get; }
}
public enum EntityType
{
    Notes = 0
}

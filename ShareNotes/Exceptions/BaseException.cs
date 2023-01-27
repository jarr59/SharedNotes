namespace ShareNotes.Exceptions;

public abstract class BaseException : Exception
{
    public BaseException(HttpErrorCode httpErrorCodeHttpErrorCode)
    {
        HttpErrorCodeHttpErrorCode = httpErrorCodeHttpErrorCode;
    }

    public HttpErrorCode HttpErrorCodeHttpErrorCode { get; private set; }
}
public enum HttpErrorCode
{
    NotFound, BadRequest
}

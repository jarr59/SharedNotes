using SharedNotes;
using ShareNotes;
using ShareNotes.Exceptions;
using ShareNotes.Interfaces;

namespace SN.Notes.Core;
public class Note : IValidationModel
{
    public string Id { get; }
    public string UserId { get; }
    public string Written { get; private set; }
    public List<UserSharedVo> UserShareds { get; set; }
    public DateTimeOffset DateCreated { get; }
    public DateTimeOffset LastModification { get; private set; }

    public void IsValid()
    {
        if (string.IsNullOrEmpty(Id))
            throw new ClientException(ClientExceptionType.RequiredField);

        if (Id.Length > Constants.KeyLength)
            throw new ClientException(ClientExceptionType.LengthFieldInvalid);

        if (string.IsNullOrEmpty(UserId))
            throw new ClientException(ClientExceptionType.RequiredField);

        if (UserId.Length > Constants.KeyLength)
            throw new ClientException(ClientExceptionType.LengthFieldInvalid);

        if (string.IsNullOrEmpty(Written))
            throw new ClientException(ClientExceptionType.RequiredField);

        if (UserId.Length > Constants.KeyLength)
            throw new ClientException(ClientExceptionType.LengthFieldInvalid);
    }
}
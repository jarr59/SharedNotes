using ShareNotes;
using ShareNotes.Exceptions;
using ShareNotes.Interfaces;

namespace SharedNotes;
public record UserSharedVo(string UserId) : IValidationModel
{
    public void IsValid()
    {
        if (string.IsNullOrEmpty(UserId))
            throw new ClientException(ClientExceptionType.RequiredField);

        if (UserId.Length > Constants.KeyLength)
            throw new ClientException(ClientExceptionType.LengthFieldInvalid);
    }
}
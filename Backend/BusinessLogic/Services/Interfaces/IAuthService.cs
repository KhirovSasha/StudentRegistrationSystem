using BusinessLogic.Dto.AuthDto;

namespace BusinessLogic.Services.Interfaces
{
    public interface IAuthService
    {
        Task<bool> Register(RegisterDto registerDto);
    }
}

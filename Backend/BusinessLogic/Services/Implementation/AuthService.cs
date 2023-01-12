using AutoMapper;
using BusinessLogic.Dto.AuthDto;
using BusinessLogic.Services.Interfaces;
using DataAccess.DataContext;
using DataAccess.Entities;

namespace BusinessLogic.Services.Implementation
{
    public class AuthService : IAuthService 
    {
        private readonly DBContext context;
        private readonly IMapper mapper;
        public AuthService(DBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<bool> Register(RegisterDto registerDto)
        {
            var newUser = mapper.Map<User>(registerDto);

            var user = context.Users.FirstOrDefault((u => u.Email == registerDto.Email ||
                u.Nikname == registerDto.Nikname));

            if (user != null) return false;

            var res = await context.Users.AddAsync(newUser);
            await context.SaveChangesAsync();

            return true;
        }
    }
}

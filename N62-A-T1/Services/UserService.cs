using AutoMapper;
using N48_HT1.DataAccess;
using N62_A_T1.DTOs;
using N62_A_T1.Models;
namespace N62_A_T1.Services
{
    public class UserService
    {
        private readonly IDataContext _dataContext;
        private IMapper _mapper;

        public UserService(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }

        public async ValueTask<User> Create (UserForCreation userForCreation) 
        {
            var newUser = _mapper.Map<User>(userForCreation);

            await _dataContext.Users.AddAsync(newUser);
            await _dataContext.SaveChangesAsync();
            return newUser;
        }

        public UserViewModel Get (Guid id)
        {
            var userViewModel = _dataContext.Users.FirstOrDefault(user => user.Id == id);

            if (userViewModel == null)
                throw new Exception("Bunday user mavjud emas!");

            var result = _mapper.Map<UserViewModel>(userViewModel);

            return result;
        }
    }
}
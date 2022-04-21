using AutoMapper;
using Blinks.Project.Application.Interface;
using Blinks.Project.Application.Model;
using Blinks.Project.Data;
using Blinks.Project.Data.Repository;
using Blinks.Project.Domain;

namespace Blinks.Project.Application.Business
{
    public class UserBusiness : IUserBusiness
    {
        public readonly IMapper _mapper;
        public UserRepository userRepository;

        public UserBusiness(IMapper mapper, UserRepository userRepository)
        {
            _mapper = mapper;
            this.userRepository = userRepository;
        }

        public void CreateUser(UserModel user)
        {
            var _mappedUser = _mapper.Map<User>(user);

            userRepository.Add(_mappedUser);
        }

        public void DeleteUser(int userId)
        {
            userRepository.Delete(userId);
        }

        public List<UserModel> GetAllUsers()
        {
            var users  = userRepository.GetAll().ToList();

            return _mapper.Map<List<UserModel>>(users);
        }

        public UserModel GetUser(int userId)
        {
            var user = userRepository.Get(userId);

            return _mapper.Map<UserModel>(user);
        }

        public void UpdateUser(UserModel user)
        {
            var _mappedUser = _mapper.Map<User>(user);

            userRepository.Add(_mappedUser);
        }
    }
}

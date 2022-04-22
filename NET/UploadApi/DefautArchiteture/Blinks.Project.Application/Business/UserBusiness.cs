using AutoMapper;
using Blinks.Project.Application.Interface;
using Blinks.Project.Application.Model;
using Blinks.Project.Data;
using Blinks.Project.Data.Contracts;
using Blinks.Project.Data.Repository;
using Blinks.Project.Domain;

namespace Blinks.Project.Application.Business
{
    /// <summary>
    /// All business rules and user implementations must be included here.
    /// </summary>
    /// <seealso cref="Blinks.Project.Application.Interface.IUserBusiness" />
    public class UserBusiness : IUserBusiness
    {
        public readonly IMapper _mapper;
        public readonly IUserRepository _userRepository;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserBusiness"/> class.
        /// </summary>
        /// <param name="mapper">The mapper.</param>
        /// <param name="userRepository">The user repository.</param>
        public UserBusiness(
            IMapper mapper,
            IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void CreateUser(UserModel user)
        {
            var _mappedUser = _mapper.Map<User>(user);

            _userRepository.Add(_mappedUser);
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        public void DeleteUser(int userId)
        {
            _userRepository.Delete(userId);
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public List<UserModel> GetAllUsers()
        {
            var users  = _userRepository.GetAll().ToList();

            return _mapper.Map<List<UserModel>>(users);
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userId">The user identifier.</param>
        /// <returns></returns>
        public UserModel GetUser(int userId)
        {
            var user = _userRepository.Get(userId);

            return _mapper.Map<UserModel>(user);
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        public void UpdateUser(UserModel user)
        {
            var _mappedUser = _mapper.Map<User>(user);

            _userRepository.Add(_mappedUser);
        }
    }
}

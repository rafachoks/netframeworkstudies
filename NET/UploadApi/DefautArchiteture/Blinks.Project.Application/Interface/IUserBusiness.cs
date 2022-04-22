using Blinks.Project.Application.Model;

namespace Blinks.Project.Application.Interface
{
    /// <summary>
    /// User business contract
    /// Every new method must be sign here first
    /// </summary>
    public interface IUserBusiness
    {
        void CreateUser(UserModel user);
        void UpdateUser(UserModel user);
        void DeleteUser(int userId);
        UserModel GetUser(int userId);
        List<UserModel> GetAllUsers();
    }
}

using Blinks.Project.Application.Model;

namespace Blinks.Project.Application.Interface
{
    public interface IUserBusiness
    {
        void CreateUser(UserModel user);
        void UpdateUser(UserModel user);
        void DeleteUser(int userId);
        UserModel GetUser(int userId);
        List<UserModel> GetAllUsers();
    }
}

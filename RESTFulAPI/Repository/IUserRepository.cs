using RESTFulAPI.Data.VO;
using RESTFulAPI.Model;

namespace RESTFulAPI.Repository
{
    public interface IUserRepository
    {
        User? ValidateCredential(UserVO user);
        User? ValidateCredential(string username);
        bool RevokeToken(string username);
        User? RefreshUserInfo(User user);
    }
}

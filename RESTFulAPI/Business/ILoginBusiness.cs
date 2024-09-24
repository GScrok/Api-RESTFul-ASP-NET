using RESTFulAPI.Data.VO;
using RESTFulAPI.Model;

namespace RESTFulAPI.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidateCredentials(UserVO user);
        TokenVO ValidateCredentials(RefreshTokenVO token);
        bool RevokeToken(string userName);
    }
}

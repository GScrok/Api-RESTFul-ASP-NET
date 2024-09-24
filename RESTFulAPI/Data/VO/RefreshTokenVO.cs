using Microsoft.AspNetCore.Http.HttpResults;

namespace RESTFulAPI.Data.VO
{
    public class RefreshTokenVO
    {
        public RefreshTokenVO(bool authenticated, string accessToken, string refreshToken)
        {
            Authenticated = authenticated;
            AccessToken = accessToken;
            RefreshToken = refreshToken;
            Created = "";
            Expiration = "";
        }

        public bool Authenticated { get; set; }
        public string Created { get; set; }
        public string Expiration { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}

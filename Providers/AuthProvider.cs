using AuthorizationService.Repository;

namespace AuthorizationService.Providers
{
    public class AuthProvider: IAuthProvider
    {
        private readonly IAuthRepo _authRepo;
        public AuthProvider(IAuthRepo authRepo)
        {
            _authRepo = authRepo;
        }
        public string GetJsonWebToken()
        {
            string token = _authRepo.GenerateJWT();
            return token;
        }
    }
}

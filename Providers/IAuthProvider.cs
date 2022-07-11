namespace AuthorizationService.Providers
{
    public interface IAuthProvider
    {
        public string GetJsonWebToken();
    }
}

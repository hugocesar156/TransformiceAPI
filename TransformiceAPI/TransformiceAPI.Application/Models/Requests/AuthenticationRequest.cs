namespace TransformiceAPI.Application.Models.Requests
{
    public class AuthenticationRequest
    {
        public string AccountName { get; init; }
        public string Password { get; init; }
    }
}

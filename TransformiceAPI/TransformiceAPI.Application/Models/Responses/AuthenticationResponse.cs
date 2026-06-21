namespace TransformiceAPI.Application.Models.Responses
{
    public class AuthenticationResponse
    {
        public AuthenticationResponse(string tokenAccess)
        {
            TokenAccess = tokenAccess;
        }

        public string TokenAccess { get; }
    }
}

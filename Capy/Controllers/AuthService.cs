namespace Capy.Controllers
{
    public class AuthService
    {
        public AuthService() { }

        public String SeesionId { get; set; }

        private static AuthService _instance;

        public static AuthService Instance(String sessionId)
        {
            if (_instance == null)
            {
                _instance = new AuthService();
                _instance.SeesionId = sessionId;
            }

            return _instance;
        }
    }
}

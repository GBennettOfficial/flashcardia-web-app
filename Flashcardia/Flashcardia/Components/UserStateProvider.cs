namespace Flashcardia.Components
{
    public class UserStateProvider
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public UserStateProvider(UserManager<ApplicationUser> userManager, AuthenticationStateProvider authenticationStateProvider)
        {
            _userManager = userManager;
            _authenticationStateProvider = authenticationStateProvider;
        }

        private UserState? _userState { get; set; }

        public async Task<UserState> Get()
        {
            if (_userState != null)
            {
                return _userState;
            }
            AuthenticationState authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            ApplicationUser? user = await _userManager.GetUserAsync(authState.User);
            _userState = new();
            _userState.User = user;
            return _userState;
        }
    }
}

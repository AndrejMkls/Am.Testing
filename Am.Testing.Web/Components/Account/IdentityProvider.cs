using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace Am.Testing.Web.Components.Account
{
    public class IdentityProvider(AuthenticationStateProvider authenticationStateProvider)
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider = authenticationStateProvider;

        public async Task<string?> GetLoggedInUserId()
        {
            var authState = await _authenticationStateProvider.GetAuthenticationStateAsync();
            if (authState.User?.Identity?.IsAuthenticated == true)
            {
                var currentUser = authState.User.Claims.FirstOrDefault(x => x.ValueType == ClaimTypes.NameIdentifier)?.Value;
                return currentUser;
            }

            return null;
        }
    }
}

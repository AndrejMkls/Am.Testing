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
                var claimNameIdentifier = authState.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);
                if (claimNameIdentifier != null)
                {
                    var currentUser = claimNameIdentifier.Value;
                    return currentUser;
                }
            }

            return null;
        }
    }
}

using Blazored.LocalStorage;
using System.Globalization;

namespace Am.Testing.Web.Components.Extensions
{
    public static class CultureExtensions
    {
        public async static Task SetDefaultLanguage(this WebApplication host)
        {
            var localStorage = host.Services.GetRequiredService<ILocalStorageService>();

            if (localStorage is not null)
            {
                var result = await localStorage.GetItemAsync<string>("language");
                CultureInfo culture;
                if (result != null)
                {
                    culture = new CultureInfo(result);
                }
                else
                {
                    culture = new CultureInfo("sk-SK");

                }

                CultureInfo.DefaultThreadCurrentCulture = culture;
                CultureInfo.DefaultThreadCurrentUICulture = culture;
            }

        }
    }

}

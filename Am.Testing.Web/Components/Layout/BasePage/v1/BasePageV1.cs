using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Radzen;

namespace Am.Testing.Web.Components.Layout.BasePage.v1
{
    public class BasePageV1 : ComponentBase
    {
        [Inject]
        public required IJSRuntime JsRuntime { get; set; }

        [Inject]
        public required NotificationService Notifications { get; set; }

        [Inject]
        public required DialogService Dialogs { get; set; }

        [Inject]
        public required NavigationManager Navigations { get; set; }

        protected bool loading = false;

        protected bool noContent = false;

        protected string? errorMessage;

    }
}

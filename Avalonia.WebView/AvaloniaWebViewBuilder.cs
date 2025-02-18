using DryIoc;
using WebView.Core.Configurations;
using WebView.Core.Ioc;

namespace Avalonia.WebView
{
    public static class AvaloniaWebViewBuilder
    {
        public static void Initialize(Action<WebViewCreationProperties>? configDelegate)
        {
            WebViewCreationProperties creationProperties = new();
            configDelegate?.Invoke(creationProperties);
            WebViewLocator.s_Registrator.RegisterInstance<WebViewCreationProperties>(creationProperties);
        }
    }

}


using AvaloniaBlazorWebView.Configurations;
using AvaloniaBlazorWebView.Core;
using AvaloniaBlazorWebView;
using WebView.Core.Configurations;
using WebView.Core.Ioc;
using Microsoft.Extensions.DependencyInjection;
using DryIoc;
namespace AvaloniaBlazorWebView
{
    public static class AvaloniaBlazorWebViewBuilder
    {
        public static void Initialize(Action<WebViewCreationProperties>? webConfigDelegate, Action<BlazorWebViewSetting> configDelegate, Action<IServiceCollection>? injectDelegate)
        {
            WebViewCreationProperties creationProperties = new();
            webConfigDelegate?.Invoke(creationProperties);
            WebViewLocator.s_Registrator.RegisterInstance<WebViewCreationProperties>(creationProperties);

            var builder = new BlazorWebViewApplicationBuilder(injectDelegate, configDelegate);
            WebViewLocator.s_Registrator.RegisterInstance<IBlazorWebViewApplicationBuilder>(builder);
        }
    }
}


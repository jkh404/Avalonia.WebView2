

namespace Avalonia.WebView.Android;

public static class AppBuilderExtensions
{
    public static AppBuilder UseAndroidWebView(this AppBuilder builder, global::Android.Content.Res.AssetManager? asset)
    {
        return builder.AfterPlatformServicesSetup(app =>
        {
            AndroidAssetFileProvider.Asset=asset;
            WebViewLocator.s_Registrator.RegisterSingleton<IViewHandlerProvider, ViewHandlerProvider>();
            WebViewLocator.s_Registrator.RegisterSingleton<IPlatformBlazorWebViewProvider, BlazorWebViewHandlerProvider>();
        });
    }
}

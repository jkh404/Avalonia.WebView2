using Avalonia.WebView.Linux;
using Avalonia.WebView.MacCatalyst;
using Avalonia.WebView.Windows;
using System.Runtime.InteropServices;

namespace Avalonia.WebView.Desktop;

public static class AppBuilderExtensions
{
    public static AppBuilder UseDesktopWebView(this AppBuilder builder, bool isWslDevelop = false)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            builder.UseWindowWebView();
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            builder.UseMacCatalystWebView();
        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            builder.UseLinuxWebView(isWslDevelop);

        return builder;
    }
}

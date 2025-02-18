using Avalonia;
using Avalonia.WebView.Shared.Core;
using Avalonia.WebView.Shared.Interfaces;

namespace Avalonia.WebView.Shared
{
    public static class AppBuilderExtensions
    {
        public static AppBuilder ConfigureAvaloniaHandlers(this AppBuilder builder, Action<IAvaloniaHandlerCollection> configureDelegate)
        {
            AvaloniaHandlerCollection list = new();
            configureDelegate?.Invoke(list);
            return builder;
        }

    }
}


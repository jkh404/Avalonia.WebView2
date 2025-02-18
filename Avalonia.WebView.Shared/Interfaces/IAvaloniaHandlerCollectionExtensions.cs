using Avalonia.WebView.Shared.Interfaces;

namespace Avalonia.WebView.Shared.Interfaces
{
    public static class IAvaloniaHandlerCollectionExtensions
    {
        public static IAvaloniaHandlerCollection AddHandler<TType, TTypeRender>(this IAvaloniaHandlerCollection handlersCollection)
        {



            return handlersCollection;
        }
    }

}

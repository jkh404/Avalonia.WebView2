using Avalonia.Controls;
using Avalonia.Interactivity;
namespace TestApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        this.blazorWebView.HostPage = "wwwroot/index.html";
        this.blazorWebView.RootComponents.Add(new AvaloniaBlazorWebView.Components.BlazorRootComponent
        {
            ComponentType= typeof(TestApp.Web.Shared.Components.Routes),
            Selector= "#mainapp"
        });
        this.blazorWebView.WebViewNewWindowRequested+=BlazorWebView_WebViewNewWindowRequested;
    }

    private void BlazorWebView_WebViewNewWindowRequested(object? sender, WebView.Core.Events.WebViewNewWindowEventArgs e)
    {
        e.UrlLoadingStrategy=WebView.Core.Enums.UrlRequestStrategy.OpenInNewWindow;
    }

    protected override void OnLoaded(RoutedEventArgs e)
    {
        base.OnLoaded(e);
        var insetsManager = TopLevel.GetTopLevel(this).InsetsManager;
        if (insetsManager!=null)
        {
            //insetsManager.IsSystemBarVisible = false;
            insetsManager.DisplayEdgeToEdge = true;
        }

    }
}
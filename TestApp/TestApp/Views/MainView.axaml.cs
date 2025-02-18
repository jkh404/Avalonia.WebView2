using Avalonia.Controls;
using TestApp.Web.Components;

namespace TestApp.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
        this.blazorWebView.HostPage = "wwwroot/index.html";
        this.blazorWebView.RootComponents.Add(new AvaloniaBlazorWebView.Components.BlazorRootComponent
        {
            ComponentType= typeof(Routes),
            Selector= "#mainapp"
        });
    }
}
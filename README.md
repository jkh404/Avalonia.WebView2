# Sky.Avalonia.WebView2 
[English](README.md)|[中文](README_ZH_CN.md)
A WebView2 control for Avalonia that supports Blazor. This project is forked from [https://github.com/sakib1361/Avalonia.WebView2](https://github.com/sakib1361/Avalonia.WebView2) and has been modified.
## Instructions
## Installation
For example, if your Avalonia project is named `TestApp` and uses a multi-project structure:
### 1. Install NuGet Packages
1. In `TestApp` install
BlazorWebView
```
dotnet add package Sky.Avalonia.BlazorWebView
```
or WebView:
```
dotnet add package Sky.Avalonia.WebView
```
2.In`TestApp.Desktop`install
```
dotnet add package Sky.Avalonia.WebView.Desktop
```
or in `TestApp.Android`install
```
dotnet add package Sky.Avalonia.WebView.Android
```
3.Edit the file:`App.axaml.cs`
```
 using AvaloniaWebView;

 OR

 using AvaloniaBlazorWebView;
 ...
  public override void RegisterServices()
  {
     base.RegisterServices();
     
     // if you use only WebView  
     AvaloniaWebViewBuilder.Initialize(default);

     // Or
 
     // if you use BlazorWebView, please setting for blazor 
     AvaloniaBlazorWebViewBuilder.Initialize(default, setting =>
     {

         //because avalonia support the html css and js for resource ,so you must set the ResourceAssembly 
         setting.IsAvaloniaResource = true;
         setting.ResourceAssembly = typeof(TestApp).Assembly;
     }, inject =>
     {
         //you can inject the resource in this
         inject.AddSingleton<WeatherForecastService>();
     });
  }
```
4.Edit the file:`MainView.axaml` 

```
<UserControl ...>
...
	<BlazorWebView x:Name="blazorWebView"/>
</UserControl>
```
5.Edit the file:`MainView.axaml.cs` 

```
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
        e.UrlLoadingStrategy=WebView.Core.Enums.UrlRequestStrategy.OpenInNewWindow;//Open links in a new window
    }

   ......
}
```
6.Edit the `Program.cs` file for Desktop projects or the `MainActivity.cs` file for Android projects
Desktop：
```
public static AppBuilder BuildAvaloniaApp()
    => AppBuilder.Configure<App>()
        .UsePlatformDetect()
        .WithInterFont()
        .LogToTrace()
        .UseWindowWebView();//add this line
```
Android：
```
protected override AppBuilder CustomizeAppBuilder(AppBuilder builder)
{
    
    return base.CustomizeAppBuilder(builder)
        .WithInterFont()
        .UseAndroidWebView();//add this line
}
```
## Notes
When running Blazor, change `<Project Sdk="Microsoft.NET.Sdk">` to `<Project Sdk="Microsoft.NET.Sdk.Razor">` in the following projects: `TestApp`, `TestApp.Desktop`, and `TestApp.Android`.
1.File: `TestApp.csproj` - Modify or add:
```
...
<ItemGroup>
  <Content Update="wwwroot\**">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </Content>
</ItemGroup>
...
```
2.File: `TestApp.Android.csproj` - Modify or add:

```
<PropertyGroup>
    ...
    <StaticWebAssetsEnabled>false</StaticWebAssetsEnabled>
</PropertyGroup>
...
<ItemGroup>
  <AndroidAsset Include="wwwroot\**">
    <CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
  </AndroidAsset>
</ItemGroup>
...
```
3. Copy the files from the `wwwroot` folder in `TestApp` to the `wwwroot` folder in `TestApp.Android`.
4. If using Blazor UI libraries, such as MudBlazor, please copy the files from `_content/MudBlazor/*` to the `wwwroot` folder in `TestApp.Android` as-is.
## Sample Project
https://github.com/jkh404/Avalonia.WebView2/tree/master/TestApp
## Screenshot Images

![android](android.png)
![desktop](desktop.png)
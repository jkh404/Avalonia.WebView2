using Microsoft.Extensions.FileProviders;
using System.Reflection;

namespace WebView.Core;

public interface IPlatformBlazorWebViewProvider
{
    string Scheme { get; }

    IFileProvider CreateFileProvider(Assembly? assembly, string contentRootDirFullPath); 
}

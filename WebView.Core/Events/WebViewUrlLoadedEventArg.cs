using System;

namespace WebView.Core.Events;

public class WebViewUrlLoadedEventArg : EventArgs
{
    public WebViewUrlLoadedEventArg(bool isSuccess, object? rawArgs)
    {
        IsSuccess=isSuccess;
        RawArgs=rawArgs;
    }
    public WebViewUrlLoadedEventArg()
    {

    }
    public bool IsSuccess { get; internal set; }
    public object? RawArgs { get; set; }

}

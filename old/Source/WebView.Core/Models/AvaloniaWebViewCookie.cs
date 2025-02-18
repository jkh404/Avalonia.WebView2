namespace WebViewCore.Models;

public class AvaloniaWebViewCookie
{
    public AvaloniaWebViewCookie(string name, string value, string domain, string path)
    {
        Name = name;
        Value = value;
        Domain = domain;
        Path = path;
    }
    public  string Name { get; set; }
    public  string Value { get; set; }
    public  string Domain { get; set; }
    public  string Path { get; set; }
}
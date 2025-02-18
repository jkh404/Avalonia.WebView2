using System.Runtime.InteropServices;

namespace Toolkit.Shared;
public sealed class OperatingSystemEx
{
    public static bool IsWindows() => OperatingSystem.IsWindows();
    public static bool IsMacOS() => OperatingSystem.IsMacOS();
    public static bool IsMacCatalyst() => OperatingSystem.IsMacCatalyst();
    public static bool IsLinux() => OperatingSystem.IsLinux();
    public static bool IsAndroid() => OperatingSystem.IsAndroid();
    public static bool IsIOS() => OperatingSystem.IsIOS();
    public static bool IsBrowser() => OperatingSystem.IsBrowser();
    public static bool IsOSPlatform(string platform) => OperatingSystem.IsOSPlatform(platform);

    public static bool IsDesktop() => IsWindows() || IsMacOS() || IsMacCatalyst() || IsLinux();
}
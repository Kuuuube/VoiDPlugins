using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Platform.Pointer;

namespace VoiDPlugins.OutputMode
{
    [PluginName("Windows Pen Pointer"), SupportedPlatform(PluginPlatform.Windows)]
    public class WindowsPenPointerOutputMode : AbsoluteOutputMode
    {
        public override IAbsolutePointer Pointer { get; set; } = new WindowsPenPointerHandler();
    }
}
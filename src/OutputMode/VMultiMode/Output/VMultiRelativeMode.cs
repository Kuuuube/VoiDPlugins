using OpenTabletDriver.Plugin;
using OpenTabletDriver.Plugin.Attributes;
using OpenTabletDriver.Plugin.Output;
using OpenTabletDriver.Plugin.Platform.Pointer;
using OpenTabletDriver.Plugin.Tablet;

namespace VoiDPlugins.OutputMode
{
    [PluginName("VMulti Relative Mode")]
    public class VMultiRelativeMode : RelativeOutputMode
    {
        private VMultiRelativePointer? _pointer;
        private readonly DummyRelativePointer _dummyPointer = new();
        public override TabletReference Tablet
        {
            get => base.Tablet;
            set
            {
                base.Tablet = value;
                _pointer = new VMultiRelativePointer(value);
            }
        }

        public override IRelativePointer Pointer
        {
            get
            {
                if (_pointer != null)
                {
                    return _pointer;
                }
                Log.Write("VMultiMode", "Pointer reference not available, returning dummy");
                return _dummyPointer;
            }
            set { }
        }
    }
}
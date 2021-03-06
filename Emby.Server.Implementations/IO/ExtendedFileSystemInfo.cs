#pragma warning disable CS1591
#pragma warning disable SA1600

namespace Emby.Server.Implementations.IO
{
    public class ExtendedFileSystemInfo
    {
        public bool IsHidden { get; set; }

        public bool IsReadOnly { get; set; }

        public bool Exists { get; set; }
    }
}

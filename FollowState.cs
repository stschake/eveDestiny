using System.Runtime.InteropServices;

namespace eveDestiny
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct FollowState
    {
        public long UnkFollowId;
        public float UnkRange;
    }
}
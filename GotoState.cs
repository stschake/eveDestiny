using System.Runtime.InteropServices;

namespace eveDestiny
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct GotoState
    {
        public Vector3 Location;
    }
}
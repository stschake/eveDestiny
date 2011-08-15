using System.Runtime.InteropServices;

namespace eveDestiny
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public class BallData
    {
        public float MaxVelocity;
        public Vector3 Velocity;
        public float Unk03;
        public float SpeedFraction;
    }
}
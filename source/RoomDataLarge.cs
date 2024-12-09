using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackroomsGenV1_1NET4_5
{
    internal class RoomDataLarge : RoomData
    {
        public bool IsHead { get { return isHead; } }
        public string[] Parts { get { return parts; } }
        public Vector3i[] PartsDisplacement { get { return partDisplacement; } }

        private bool isHead;
        private string[] parts;
        private Vector3i[] partDisplacement;

        public RoomDataLarge(string f, float w, Dictionary<string, float> ow, int sx, int sz, Vector3i[] sp, bool isHead, string[] parts, Vector3i[] partDisplacement) : base(f, w, ow, sx, sz, sp)
        {
            this.isHead = isHead;
            this.parts = parts;
            this.partDisplacement = partDisplacement;
        }
    }
}

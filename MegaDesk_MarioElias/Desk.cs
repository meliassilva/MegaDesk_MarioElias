using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_MarioElias
{
    public struct Desk
    {
        public enum DesktopMaterial
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public float Width { get; set; }

        public float Depth { get; set; }

        public DesktopMaterial Material { get; set; }

        public int NumberOfDrawers { get; set; }

    }
}

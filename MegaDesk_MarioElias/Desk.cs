using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_MarioElias
{
    public struct Desk
    {
        public enum Surface
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public decimal Width { get; set; }

        public decimal Depth { get; set; }

        public Surface Material { get; set; }

        public int NumberOfDrawers { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_ShapesProject {

    public class Rect : Quad{

        public override double GetArea() {
            return this.side1 * this.side2;
        }

        public Rect(int side_x, int side_y) : base(side_x, side_y, side_x, side_y) {

        }
    }
}

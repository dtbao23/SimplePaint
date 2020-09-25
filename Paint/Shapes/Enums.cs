using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public enum CurrentShape
    {
        Line,
        Rectangle,
        Square,
        Ellipse,
        Circle,  
        Pyramid,
        Bezier,
        Polygon,
        Rhombus,
        NoDrawing
    }
    public enum ShapeMode
    {
        Fill,
        NoFill
    }
}

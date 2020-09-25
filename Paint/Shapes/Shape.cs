﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public abstract class Shape : ICloneable
    {
        public Point Begin { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public bool FillColor { get; set; }// FIll 
        public int LineWidth { get; set; }
        public bool IsSelected { get; set; }
        public string Name { get; protected set; }
        public DashStyle DashStyle { get; set; } = DashStyle.Solid;

        protected abstract GraphicsPath GraphicsPath { get; }
        public abstract bool IsHit(Point point);
        public abstract void Draw(Graphics graphics);
        public abstract void Move(Point distance);

        public abstract object Clone();

        public override string ToString()
        {
            return $"{Name} [({Begin.X}, {Begin.Y}); ({End.X}, {End.Y})]";
        }
    }
}

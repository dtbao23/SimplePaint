using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle()
        {
            Name = "Rectangle";
        }

        protected override GraphicsPath GraphicsPath
        {
            get
            {
                GraphicsPath path = new GraphicsPath();
                if (End.X < Begin.X && End.Y < Begin.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(End, new Size(Begin.X - End.X, Begin.Y - End.Y)));
                }
                else if (Begin.X > End.X && Begin.Y < End.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(new Point(End.X, Begin.Y), new Size(Begin.X - End.X, End.Y - Begin.Y)));
                }
                else if (Begin.X < End.X && Begin.Y > End.Y)
                {
                    path.AddRectangle(new System.Drawing.Rectangle(new Point(Begin.X, End.Y), new Size(End.X - Begin.X, Begin.Y - End.Y)));
                }
                else
                {
                    path.AddRectangle(new System.Drawing.Rectangle(Begin, new Size(End.X - Begin.X, End.Y - Begin.Y)));
                }

                return path;
            }
        }

        public override object Clone()
        {
            return new Rectangle
            {
                Begin = Begin,
                End = End,
                LineWidth = LineWidth,
                Color = Color,
                IsSelected = IsSelected,
                Name = Name
            };
        }

        public override void Draw(Graphics graphics)
        {
            using (GraphicsPath path = GraphicsPath)
            {
                if (!FillColor)
                {
                    using (Pen pen = new Pen(Color, LineWidth) { DashStyle = DashStyle })
                    {
                        graphics.DrawPath(pen, path);
                    }
                }
                else
                {
                    using (Brush brush = new SolidBrush(Color))
                    {
                        graphics.FillPath(brush, path);
                    }
                }
            }
        }

        public override bool IsHit(Point point)
        {
            bool res = false;
            using (GraphicsPath path = GraphicsPath)
            {
                if (!FillColor)
                {
                    using (Pen pen = new Pen(Color, LineWidth + 3))
                    {
                        res = path.IsOutlineVisible(point, pen);
                    }
                }
                else
                {
                    res = path.IsVisible(point);
                }
            }
            return res;

        }

        public override void Move(Point distance)
        {
            Begin = new Point(Begin.X + distance.X, Begin.Y + distance.Y);
            End = new Point(End.X + distance.X, End.Y + distance.Y);
        }
    }
}

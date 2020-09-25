using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class frmPaint : Form
    {
        private List<Button> buttons;
        private List<Shape> shapes = new List<Shape>();
        private CurrentShape currentShape = CurrentShape.NoDrawing;
        private Point previousPoint;
        private ShapeMode mode = ShapeMode.NoFill;
        private Brush brush = new SolidBrush(Color.Blue);
        private Pen framePen = new Pen(Color.Blue, 1)
        {
            DashPattern = new float[] { 3, 3, 3, 3 },
            DashStyle = DashStyle.Custom
        };
        private Shape selectedShape;
        private System.Drawing.Rectangle selectedRegion;
        private bool isMouseDown;
        private bool isDrawCurve;
        private bool isDrawPolygon;
        private bool isDrawPyramid;
        private bool isDrawBezier;
        private bool isMovingShape;
        private bool isControlKeyPress;
        private bool isMouseSelect;
        private int movingOffset;
        public frmPaint()
        {
            InitializeComponent();
            buttons = new List<Button> { btnBezier, btnCircle,  btnEllipse, btnLine, btnPolygon, btnRectangle, btnSelect, btnSquare , btnPyramid, btnRhombus};
          
        }
        private void UncheckAll()
        {
            buttons.ForEach(button => button.BackColor = Color.Transparent);
        }
        private void FindCurveRegion(Curve curve)
        {
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
            curve.Points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            curve.Begin = new Point(minX, minY);
            curve.End = new Point(maxX, maxY);
        }
        private void FindPolygonRegion(Polygon polygon)
        {
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
            polygon.Points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y) 
                {
                    maxY = p.Y;
                }
            });
            polygon.Begin = new Point(minX, minY);
            polygon.End = new Point(maxX, maxY);
        }
        private void FindPyramidRegion(Pyramid pyramid)
        {
            int minX = int.MaxValue, minY = int.MaxValue, maxX = int.MinValue, maxY = int.MinValue;
            pyramid.Points.ForEach(p =>
            {
                if (minX > p.X)
                {
                    minX = p.X;
                }
                if (minY > p.Y)
                {
                    minY = p.Y;
                }
                if (maxX < p.X)
                {
                    maxX = p.X;
                }
                if (maxY < p.Y)
                {
                    maxY = p.Y;
                }
            });
            pyramid.Begin = new Point(minX, minY);
            pyramid.End = new Point(maxX, maxY);
        }
        private void EnableButtons()
        {
            buttons.ForEach(button => button.Enabled = true);
        }
        private void MoveShape(Action<int> action)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    action(i);
                }
            }
            KhungVe.Invalidate();
        }
       
        private void ToRight(int index)
        {
            Shape shape = shapes[index];
            if (shape is Polygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new Point(polygon.Points[j].X + movingOffset, polygon.Points[j].Y);
                }
            }
            else if (shape is Pyramid pyramid)
            {
                for (int j = 0; j < pyramid.Points.Count; j++)
                {
                    pyramid.Points[j] = new Point(pyramid.Points[j].X + movingOffset, pyramid.Points[j].Y);
                }
            }

            shape.Begin = new Point(shape.Begin.X + movingOffset, shape.Begin.Y);
            shape.End = new Point(shape.End.X + movingOffset, shape.End.Y);
        }
       
        private void ToUp(int index)
        {
            Shape shape = shapes[index];
            if (shape is Polygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new Point(polygon.Points[j].X, polygon.Points[j].Y - movingOffset);
                }
            }
            else if (shape is Pyramid pyramid)
            {
                for (int j = 0; j < pyramid.Points.Count; j++)
                {
                    pyramid.Points[j] = new Point(pyramid.Points[j].X, pyramid.Points[j].Y - movingOffset);
                }
            }

            shape.Begin = new Point(shape.Begin.X, shape.Begin.Y - movingOffset);
            shape.End = new Point(shape.End.X, shape.End.Y - movingOffset);
        }
      
        private void ToDown(int index)
        {
            Shape shape = shapes[index];
           if (shape is Polygon polygon)
           {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new Point(polygon.Points[j].X, polygon.Points[j].Y + movingOffset);
                }
           }
           else if (shape is Pyramid pyramid)
            {
                for (int j = 0; j < pyramid.Points.Count; j++)
                {
                    pyramid.Points[j] = new Point(pyramid.Points[j].X, pyramid.Points[j].Y + movingOffset);
                }
            }
            shape.Begin = new Point(shape.Begin.X, shape.Begin.Y + movingOffset);
            shape.End = new Point(shape.End.X, shape.End.Y + movingOffset);
        }
       
        private void ToLeft(int index)
        {
            Shape shape = shapes[index];
            if (shape is Polygon polygon)
            {
                for (int j = 0; j < polygon.Points.Count; j++)
                {
                    polygon.Points[j] = new Point(polygon.Points[j].X - movingOffset, polygon.Points[j].Y);
                }
            }
            else if (shape is Pyramid pyramid)
            {
                for (int j = 0; j < pyramid.Points.Count; j++)
                {
                    pyramid.Points[j] = new Point(pyramid.Points[j].X - movingOffset, pyramid.Points[j].Y);
                }
            }
            shape.Begin = new Point(shape.Begin.X - movingOffset, shape.Begin.Y);
            shape.End = new Point(shape.End.X - movingOffset, shape.End.Y);
        }

        private void KhungVe_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            shapes.ForEach(shape =>
            {
                if (shape.IsSelected)
                {
                    shape.Draw(e.Graphics);
                    if (shape is Ellipse )
                    {
                        e.Graphics.DrawRectangle(framePen, new System.Drawing.Rectangle(shape.Begin.X, shape.Begin.Y, shape.End.X - shape.Begin.X, shape.End.Y - shape.Begin.Y));
                    }
                   
                    else if (shape is Polygon polygon)
                    {
                        for (int i = 0; i < polygon.Points.Count; i++)
                        {
                            e.Graphics.FillEllipse(brush, new System.Drawing.Rectangle(polygon.Points[i].X - 4, polygon.Points[i].Y - 4, 8, 8));
                        }
                    }
                    else if (shape is Pyramid pyramid)// ve tam giac
                    {
                        for (int i = 0; i < pyramid.Points.Count; i++)
                        {
                            e.Graphics.FillEllipse(brush, new System.Drawing.Rectangle(pyramid.Points[i].X - 4, pyramid.Points[i].Y - 4, 8, 8));
                        }
                    }
                    else
                    {
                        e.Graphics.FillEllipse(brush, new System.Drawing.Rectangle(shape.Begin.X - 4, shape.Begin.Y - 4, 8, 8));
                        e.Graphics.FillEllipse(brush, new System.Drawing.Rectangle(shape.End.X - 4, shape.End.Y - 4, 8, 8));
                    }
                }
                else
                {
                    shape.Draw(e.Graphics);
                }
            });

            if (isMouseSelect)
            {
                e.Graphics.DrawRectangle(framePen, selectedRegion);
            }
           
        }

        private void KhungVe_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentShape == CurrentShape.NoDrawing)
            {
                if (isControlKeyPress)
                {
                    for (int i = 0; i < shapes.Count; i++)
                    {
                        if (shapes[i].IsHit(e.Location))
                        {
                            shapes[i].IsSelected = !shapes[i].IsSelected;                           
                            KhungVe.Invalidate();
                            break;
                        }
                    }
                }
                else
                {
                    shapes.ForEach(shape => shape.IsSelected = false);
                    KhungVe.Invalidate();                 

                    for (int i = 0; i < shapes.Count; i++)
                    {
                        if (shapes[i].IsHit(e.Location))
                        {
                            selectedShape = shapes[i];
                            shapes[i].IsSelected = true;                           

                            KhungVe.Invalidate();
                            break;
                        }
                    }

                    if (selectedShape != null)
                    {
                        isMovingShape = true;
                        previousPoint = e.Location;
                    }
                    else
                    {
                        isMouseSelect = true;
                        selectedRegion = new System.Drawing.Rectangle(e.Location, new Size(0, 0));
                    }
                }
            }
            else
            {
                isMouseDown = true;
                shapes.ForEach(shape => shape.IsSelected = false);

                if (currentShape == CurrentShape.Line)
                {
                    Line line = new Line
                    {
                        Begin = e.Location,
                        LineWidth = cbSize.SelectedIndex,
                        Color = btnColors.BackColor,
                        DashStyle = DashStyle.Solid
                    };
                    shapes.Add(line);
                }
                else if (currentShape == CurrentShape.Rectangle)
                {
                    Shapes.Rectangle rectangle = new Shapes.Rectangle
                    {
                        Begin = e.Location,
                        LineWidth = cbSize.SelectedIndex,
                        Color = btnColors.BackColor,
                        DashStyle = DashStyle.Solid
                    };

                    

                    shapes.Add(rectangle);
                }
                else if (currentShape == CurrentShape.Ellipse)
                {
                    Ellipse ellipse = new Ellipse
                    {
                        Begin = e.Location,
                        LineWidth = cbSize.SelectedIndex,
                        Color = btnColors.BackColor,
                        DashStyle = DashStyle.Solid
                    };

                    

                    shapes.Add(ellipse);
                }
                else if (currentShape == CurrentShape.Square)
                {
                    Square square = new Square
                    {
                        Begin = e.Location,
                        LineWidth = cbSize.SelectedIndex,
                        Color = btnColors.BackColor,
                        DashStyle = DashStyle.Solid
                    };

                    

                    shapes.Add(square);
                }
                else if (currentShape == CurrentShape.Circle)
                {
                    Circle circle = new Circle
                    {
                        Begin = e.Location,
                        LineWidth = cbSize.SelectedIndex,
                        Color = btnColors.BackColor,
                        DashStyle = DashStyle.Solid
                    };

                    

                    shapes.Add(circle);
                }
                else if (currentShape == CurrentShape.Polygon)
                {
                    if (!isDrawPolygon)
                    {
                        Polygon polygon = new Polygon
                        {
                            LineWidth = cbSize.SelectedIndex,
                            Color = btnColors.BackColor,
                            DashStyle = DashStyle.Solid
                        };
                      
                        polygon.Points.Add(e.Location);
                        polygon.Points.Add(e.Location);

                        shapes.Add(polygon);

                        isDrawPolygon = true;
                    }
                    else
                    {
                        Polygon polygon = shapes[shapes.Count - 1] as Polygon;
                        polygon.Points[polygon.Points.Count - 1] = e.Location;
                        polygon.Points.Add(e.Location);
                    }

                    isMouseDown = false;
                }
                else if (currentShape == CurrentShape.Pyramid)
                {
                    if (!isDrawPyramid)
                    {
                        Pyramid pyramid = new Pyramid
                        {
                            LineWidth = cbSize.SelectedIndex,
                            Color = btnColors.BackColor,
                            DashStyle = DashStyle.Solid
                        };
                        pyramid.Points.Add(e.Location);
                        pyramid.Points.Add(e.Location);

                        shapes.Add(pyramid);

                        isDrawPyramid = true;
                    }
                    else
                    {                      
                        Pyramid pyramid = shapes[shapes.Count - 1] as Pyramid;
                        pyramid.Points[pyramid.Points.Count - 1] = e.Location;
                        pyramid.Points.Add(e.Location);
                        if (pyramid.Points.Count == 4)
                            isDrawPyramid = false;
                    }
                    isMouseDown = false;
                }
                else if (currentShape == CurrentShape.Bezier)
                {
                    if (!isDrawBezier)
                    {
                        Curve bezier = new Curve
                        {
                            LineWidth = cbSize.SelectedIndex,
                            Color = btnColors.BackColor,
                            DashStyle = DashStyle.Solid
                        };
                        bezier.Points.Add(e.Location);
                        bezier.Points.Add(e.Location);

                        shapes.Add(bezier);

                        isDrawBezier = true;
                    }
                    else
                    {
                        Curve bezier = shapes[shapes.Count - 1] as Curve;
                        if (bezier.Points.Count < 4)
                        {
                            bezier.Points[bezier.Points.Count - 1] = e.Location;
                            bezier.Points.Add(e.Location);
                        }
                        else
                        {
                            isDrawBezier = false;
                            FindCurveRegion(bezier);
                        }
                    }
                    isMouseDown = false;
                }
            }
        }

        private void KhungVe_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                shapes[shapes.Count - 1].End = e.Location;
                KhungVe.Invalidate();
            }
            else if (isMovingShape)
            {
                Point d = new Point(e.X - previousPoint.X, e.Y - previousPoint.Y);
                selectedShape.Move(d);
                previousPoint = e.Location;

                KhungVe.Invalidate();
            }
            else if (currentShape == CurrentShape.NoDrawing)
            {
                if (isMouseSelect)
                {
                    selectedRegion.Width = e.Location.X - selectedRegion.X;
                    selectedRegion.Height = e.Location.Y - selectedRegion.Y;

                    KhungVe.Invalidate();
                }
                else
                {
                    if (shapes.Exists(shape => shape.IsHit(e.Location)))
                    {
                        KhungVe.Cursor = Cursors.SizeAll;
                    }
                    else
                    {
                        KhungVe.Cursor = Cursors.Default;
                    }
                }
            }

            if (isDrawPolygon)
            {
                Polygon polygon = shapes[shapes.Count - 1] as Polygon;
                polygon.Points[polygon.Points.Count - 1] = e.Location;

                KhungVe.Invalidate();
            }
            else if (isDrawPyramid)
            {
                Pyramid pyramid = shapes[shapes.Count - 1] as Pyramid;
                pyramid.Points[pyramid.Points.Count - 1] = e.Location;

                KhungVe.Invalidate();
            }
            else if (isDrawCurve)
            {
                Curve curve = shapes[shapes.Count - 1] as Curve;
                curve.Points[curve.Points.Count - 1] = e.Location;

                KhungVe.Invalidate();
            }
            else if (isDrawBezier)
            {
                Curve bezier = shapes[shapes.Count - 1] as Curve;
                bezier.Points[bezier.Points.Count - 1] = e.Location;

                KhungVe.Invalidate();
            }
        }

        private void KhungVe_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            if (isMovingShape)
            {
                isMovingShape = false;
                selectedShape = null;
            }
            else if (isMouseSelect)
            {
                isMouseSelect = false;
                for (int i = 0; i < shapes.Count; i++)
                {
                    
                    shapes[i].IsSelected = false;

                    if (shapes[i].Begin.X >= selectedRegion.X && shapes[i].End.X <= selectedRegion.X + selectedRegion.Width && shapes[i].Begin.Y >= selectedRegion.Y && shapes[i].End.Y <= selectedRegion.Y + selectedRegion.Height)
                    {
                       
                        shapes[i].IsSelected = true;
                    }
                }

                KhungVe.Invalidate();
            }

            try
            {
                Shape shape = shapes[shapes.Count - 1];
                if (shape.Begin.X > shape.End.X || (shape.Begin.X == shape.End.X && shape.Begin.Y > shape.End.Y))
                {
                    Point temp = shape.Begin;
                    shape.Begin = shape.End;
                    shape.End = temp;
                }

                if (shape is Circle circle)
                {
                    circle.End = new Point(circle.Begin.X + circle.Diameter, circle.Begin.Y + circle.Diameter);
                }
                else if (shape is Square square)
                {
                    if (square.Begin.X < square.End.X && square.Begin.Y > square.End.Y)
                    {
                        square.Begin = new Point(square.Begin.X, square.End.Y);
                        square.End = new Point(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                    else
                    {
                        square.End = new Point(square.Begin.X + square.Width, square.Begin.Y + square.Width);
                    }
                }
                else if (shape is Shapes.Rectangle rect)
                {
                    if (rect.Begin.X < rect.End.X && rect.Begin.Y > rect.End.Y)
                    {
                        Point begin = rect.Begin, end = rect.End;

                        rect.Begin = new Point(begin.X, end.Y);
                        rect.End = new Point(end.X, begin.Y);
                    }
                }

               
            }
            catch
            {
            }
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();

           
            if (btnLine.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Line;
                btnLine.BackColor = Color.Silver;
            }
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();

           
            if (btnRectangle.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Rectangle;
                btnRectangle.BackColor = Color.Silver;
            }
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();


            if (btnSquare.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Square;
                btnSquare.BackColor = Color.Silver;
            }
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();

           

            if (btnEllipse.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Ellipse;
                btnEllipse.BackColor = Color.Silver;
            }
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();


            if (btnCircle.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Circle;
                btnCircle.BackColor = Color.Silver;
            }
        }

        private void btnBezier_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();

           

            if (btnBezier.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Bezier;
                btnBezier.BackColor = Color.Silver;
            }
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();

           

            if (btnPolygon.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Polygon;
                btnPolygon.BackColor = Color.Silver;
            }
        }
        private void btnPyramid_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();



            if (btnPyramid.BackColor == Color.Silver)
            {
                UncheckAll();
                currentShape = CurrentShape.NoDrawing;
                KhungVe.Cursor = Cursors.Default;
                btnSelect.BackColor = Color.Silver;
            }
            else
            {
                UncheckAll();
                KhungVe.Cursor = Cursors.Cross;
                currentShape = CurrentShape.Pyramid;
                btnPyramid.BackColor = Color.Silver;
            }
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            shapes.ForEach(shape => shape.IsSelected = false);
            KhungVe.Invalidate();           
            currentShape = CurrentShape.NoDrawing;
            UncheckAll();
            btnSelect.BackColor = Color.Silver;
            KhungVe.Cursor = Cursors.Default;
        }

        private void KhungVe_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (isDrawPolygon)
            {
                isDrawPolygon = false;

                Polygon polygon = shapes[shapes.Count - 1] as Polygon;
                polygon.Points.RemoveAt(polygon.Points.Count - 1);

                KhungVe.Invalidate();

                FindPolygonRegion(polygon);
            }
            else if (isDrawPyramid)
            {
                isDrawPyramid = false;

                Pyramid pyramid = shapes[shapes.Count - 1] as Pyramid;
                pyramid.Points.RemoveAt(pyramid.Points.Count - 1);

                KhungVe.Invalidate();

                FindPyramidRegion(pyramid);
            }
            else if (isDrawCurve)
            {
                isDrawCurve = false;

                Curve curve = shapes[shapes.Count - 1] as Curve;
                curve.Points.RemoveAt(curve.Points.Count - 1);
                curve.Points.RemoveAt(curve.Points.Count - 1);

                KhungVe.Invalidate();

                FindCurveRegion(curve);
            }
        }

        private void frmPaint_KeyDown(object sender, KeyEventArgs e)
        {
            isControlKeyPress = e.Control;
            KhungVe.Focus();

            if (e.Control)
            {
                movingOffset = 1;
            }
            else
            {
                movingOffset = 5;
            }

            if (e.KeyCode == Keys.Up)
            {
                MoveShape(ToUp);
            }
            else if (e.KeyCode == Keys.Down)
            {
                MoveShape(ToDown);
            }
            else if (e.KeyCode == Keys.Left)
            {
                MoveShape(ToLeft);
            }
            else if (e.KeyCode == Keys.Right)
            {
                MoveShape(ToRight);
            }
            else if (e.KeyCode == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }

        private void frmPaint_KeyUp(object sender, KeyEventArgs e)
        {
            isControlKeyPress = e.Control;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    shapes.RemoveAt(i);
                   
                }
            }
            KhungVe.Invalidate();
            
        }

        private void btnColors_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btnColors.BackColor = color.Color;
            }          
            KhungVe.Invalidate();
        }

        private void btnRhombus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng này đang được phát triển !!!");
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    shapes[i].FillColor = true;
                    shapes[i].Color = btnColors.BackColor;
                }
            }
            KhungVe.Invalidate();
        }
        public void Translate(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.TranslateTransform(this.Width / 2, this.Height / 2);
            g.RotateTransform(int.Parse(cbXoayHinh.Text.ToString()));
            g.TranslateTransform(this.Width / 2, this.Height / 2);
        }

        private void cbXoayHinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i].IsSelected)
                {
                    MessageBox.Show("Chức năng này đang được phát triển !!!");
                   
                }
            }
            
        }

        private void btnHuongDan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Các hình phải được chọn trước khi sử dụng các thao tác tô, di chuyển, xóa");
        }
    }
}

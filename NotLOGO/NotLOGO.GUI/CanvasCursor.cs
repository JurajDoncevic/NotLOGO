using NotLOGO.Core;
using System;
using System.Collections.Generic;
using System.Windows.Shapes;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;

namespace NotLOGO.GUI
{
    public class CanvasCursor : CursorBase<Rectangle>
    {
        public override int XCoordinate
        {
            get
            {
                return (int)(Canvas.GetLeft(Representation) + Representation.Width / 2);
            }
        }
        public override int YCoordinate
        {
            get
            {
                return (int)(Canvas.GetTop(Representation) + Representation.Height / 2);
            }
        }

        public override int Rotation
        {
            get
            {
                return (int)(Representation.RenderTransform as RotateTransform).Angle;
            }
        }

        public Color PenColor { get; set; } = Colors.Black;
        public int PenThickness { get; set; } = 1;

        private Canvas _parentCanvas;

        public CanvasCursor(Rectangle representation) : base(representation)
        {
            _parentCanvas = (Canvas)Representation.Parent;
            Representation.RenderTransform = new RotateTransform(0);
        }

        public void CenterOnCanvas()
        {
            Canvas.SetLeft(Representation, _parentCanvas.ActualWidth / 2 - Representation.Width / 2);
            Canvas.SetTop(Representation, _parentCanvas.ActualHeight / 2 - Representation.Height / 2);
        }

        public override void MoveBackward(int pixels)
        {
            int deltaX = (int)(Math.Sin(Rotation) * pixels);
            int deltaY = (int)(Math.Cos(Rotation) * pixels);
            int newCoorX = XCoordinate - deltaX;
            int newCoorY = YCoordinate + deltaY;
            if (IsPenDown)
            {
                DrawLine(XCoordinate, YCoordinate, newCoorX, newCoorY);
            }
            Canvas.SetLeft(Representation, newCoorX);
            Canvas.SetTop(Representation, newCoorY);
        }

        public override void MoveForward(int pixels)
        {
            int deltaX = (int)(Math.Sin(Rotation) * pixels);
            int deltaY = (int)(Math.Cos(Rotation) * pixels);
            int newCoorX = XCoordinate + deltaX;
            int newCoorY = YCoordinate - deltaY;
            if (IsPenDown)
            {
                DrawLine(XCoordinate, YCoordinate, newCoorX, newCoorY);
            }
            Canvas.SetLeft(Representation, newCoorX);
            Canvas.SetTop(Representation, newCoorY);
        }

        public override void RotateLeft(int degrees)
        {
            RotateTransform rotateTransform = Representation.RenderTransform as RotateTransform;
            rotateTransform.CenterX = XCoordinate;
            rotateTransform.CenterY = YCoordinate;
            rotateTransform.Angle = Rotation - degrees;
        }

        public override void RotateRight(int degrees)
        {
            RotateTransform rotateTransform = Representation.RenderTransform as RotateTransform;
            rotateTransform.CenterX = XCoordinate;
            rotateTransform.CenterY = YCoordinate;
            rotateTransform.Angle = Rotation + degrees;
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            var line = new Line();
            var brush = new SolidColorBrush();
            brush.Color = PenColor;
            line.Stroke = brush;
            line.StrokeThickness = PenThickness;
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;
            _parentCanvas.Children.Add(line);
        }
    }
}

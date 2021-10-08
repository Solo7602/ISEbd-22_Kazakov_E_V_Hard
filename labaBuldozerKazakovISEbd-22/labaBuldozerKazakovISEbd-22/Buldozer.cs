using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace labaBuldozerKazakovISEbd_22
{
	class Bulldozer
	{
		private float _startPosX;
		private float _startPosY;
		private float PicWidth;
		private float PicHeight;
		private readonly int BulldozerWidth = 270;
		private readonly int BulldozerHeight = 152;
		public int MaxSpeed { private set; get; }
		public float Weight { private set; get; }
		public Color MainColor { private set; get; }
		public Color DopColor { private set; get; }
		public bool Bucket { private set; get; }
		public bool BackSpoiler { private set; get; }
		public bool SportLine { private set; get; }
		private Wheels Wheel = new Wheels();
		public void Init(int maxSpeed, float weight, Color mainColor, Color dopColor,
bool bucket, bool backSpoiler, bool sportLine, int CountWheels)
		{
			MaxSpeed = maxSpeed;
			Weight = weight;
			MainColor = mainColor;
			DopColor = dopColor;
			Bucket = bucket;
			BackSpoiler = backSpoiler;
			SportLine = sportLine;
			Wheel.WheelCount = CountWheels;
		}
		public void SetPosition(int x, int y, int width, int height)
		{
			_startPosX = x;
			_startPosY = y;
			PicHeight = height;
			PicWidth = width;
		}
        public void MoveTransport(Direction direction)
		{
			float step = MaxSpeed * 100 / Weight;
			switch (direction)
			{
				// вправо
				case Direction.Right:
					if (_startPosX+step < PicWidth - BulldozerWidth)
					{
						_startPosX += step;
					}
					break;
				//влево
				case Direction.Left:
					if(_startPosX -step > 0)
					{
						_startPosX -= step;
					}
					break;
				//вверх
				case Direction.Up:
					if (_startPosY - step > 0)
					{
						_startPosY -= step;
					}
					break;
				//вниз
				case Direction.Down:
					if (_startPosY + step < PicHeight - BulldozerHeight)
					{
						_startPosY += step;
					}
					break;
			}
		}
		public void DrawTransport(Graphics g)
		{
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, _startPosX+70, _startPosY+51, 150, 50);
            Brush brRed = new SolidBrush(Color.Red);
            g.FillRectangle(brRed, _startPosX + 71, _startPosY + 52, 149, 50);
            Brush brBlue = new SolidBrush(Color.Blue);
            g.DrawRectangle(pen, _startPosX + 89, _startPosY, 20, 50);
            g.FillRectangle(brBlue, _startPosX + 90, _startPosY +2, 20, 50);
            g.DrawRectangle(pen, _startPosX + 170, _startPosY +2, 50, 50);
            g.DrawLine(pen, _startPosX+70, _startPosY + 101, _startPosX + 220, _startPosY + 101);
            g.DrawLine(pen, _startPosX+70, _startPosY + 151, _startPosX + 220, _startPosY + 151);
            g.DrawArc(pen, _startPosX + 50, _startPosY + 101, 50, 50, 90, 180);
            g.DrawArc(pen, _startPosX + 190, _startPosY + 101, 50, 50, 270, 180);
            g.DrawLine(pen, _startPosX+70, _startPosY + 76, _startPosX +40, _startPosY + 76);
            g.DrawLine(pen, _startPosX + 40, _startPosY+51, _startPosX + 40, _startPosY + 151);
            g.DrawLine(pen, _startPosX + 40, _startPosY + 151, _startPosX, _startPosY + 151);
            g.DrawLine(pen, _startPosX, _startPosY + 151, _startPosX +40, _startPosY + 51);
            g.DrawLine(pen, _startPosX + 220, _startPosY + 71, _startPosX + 250, _startPosY+51);
            g.DrawLine(pen, _startPosX + 220, _startPosY + 91, _startPosX + 250, _startPosY+51);
            g.DrawRectangle(pen, _startPosX + 230, _startPosY + 31, 40, 20);
            Pen roll = new Pen(Color.Black, 4);
            g.DrawEllipse(roll, _startPosX + 100, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 130, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 160, _startPosY + 130, 20, 20);
            g.DrawEllipse(roll, _startPosX + 150, _startPosY + 111, 10, 10);
            g.DrawEllipse(roll, _startPosX + 120, _startPosY + 111, 10, 10);
            g.DrawEllipse(roll, _startPosX + 55, _startPosY + 106, 40, 40);
            g.DrawEllipse(roll, _startPosX + 195, _startPosY + 106, 40, 40);
			g.DrawLine(pen, _startPosX + 120, _startPosY + 51, _startPosX + 120, _startPosY + 40);
			g.DrawLine(pen, _startPosX + 140, _startPosY + 51, _startPosX + 140, _startPosY + 40);
			g.DrawArc(pen, _startPosX + 120, _startPosY + 30, 20, 20, 180, 180);
			Wheel.DrawWheels(g, _startPosX, _startPosY);
		}
	}
}

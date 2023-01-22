using System;
namespace juneOOP2_exercises
{
	public class Rectangle : IFigure
	{
		private int height;
		private int width;

		public Rectangle(int height, int width)
		{
			this.height = height;
			this.width = width;
		}

		public int GetArea()
		{
			return height * width;
		}

		public int GetWidth()
		{
			return width;
		}
	}
}


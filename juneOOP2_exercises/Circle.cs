using System;
namespace juneOOP2_exercises
{
	public class Circle : IFigure
	{
		private int r;

		public Circle(int r)
		{
			this.r = r;
		}

		public int GetArea()
		{
			return (int)(Math.PI * r * r);
		}
	}
}


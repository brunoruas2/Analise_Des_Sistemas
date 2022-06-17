namespace WorkSpace
{
	class circulo
	{
		private double _raio;

		public double raio
		{
			get { return _raio; }
			set
			{
				if (value < 0)
					_raio = 0;
				else
					_raio = value;
			}
		}
		public double calcArea()
		{
			return Math.PI* Math.Pow(_raio, 2);
		}
	}

	class Program
    {
		static void Main(string[] args)
        {
			double area;

			circulo xcir = new circulo();
			xcir.raio = -2.5;
			area = xcir.calcArea();

			Console.WriteLine($"Area: {area:F2}");
        }
    }
}

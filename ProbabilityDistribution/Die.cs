namespace ProbabilityDistribution
{
	using System;

	class Die : IDie
	{
		// Fields.
		private int value;
		private Random random;

		// Property.
		public int Value { get { return value; } }

		// Constructor.
		public Die()
		{
			random = new Random();
			Roll();
		}

		// Method.
		public void Roll() { value = random.Next(1, 7); }
	}
}
namespace ProbabilityDistribution
{
	using System.Collections.Generic;

	class Statistician : IStatistician
	{
		// Fields.
		private Die die;
		private Dictionary<int, int> results;

		// Property.
		public IDictionary<int, int> Results { get { return results; } }

		// Constructor.
		public Statistician()
		{
			die = new Die();
			results = new Dictionary<int, int>();
			for (int i = 1; i < 7; i++)
				results.Add(i, 0);
		}

		// Methods.
		public void Experiment(int iterations)
		{
			for (int i = 0; i < iterations; i++)
			{
				die.Roll();
				results[die.Value] = ++results[die.Value];
			}
		}
	}
}
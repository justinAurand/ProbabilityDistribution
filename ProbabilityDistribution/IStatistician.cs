namespace ProbabilityDistribution
{
	using System.Collections.Generic;

	interface IStatistician
	{
		// Return the results in a dictionary object. <DieValue, NumberOfInstances>
		IDictionary<int, int> Results { get; }

		// Roll a die and record the resulting value.
		void Experiment(int numberOfRolls);
	}
}

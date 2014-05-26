namespace ProbabilityDistribution
{
	interface IDie
	{
		// Return the current value of the die.
		int Value { get; }

		// Roll the die.
		void Roll();
	}
}
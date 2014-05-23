namespace ProbabilityDistribution
{
	using System;
	using System.Collections.Generic;

	class Conductor
	{
		// Conduct the experiment. Display the results of the experiment.
		public static void Main()
		{
			IStatistician statistician = new Statistician();
			ReportHeader();

			statistician.Experiment(10);
			ReportRow(10, statistician.Results);

			int experiments = 90;
			int rolls = 100;
			for (int i = 0; i < 5; i++)
			{
				statistician.Experiment(experiments);
				ReportRow(rolls, statistician.Results);
				experiments *= 10;
				rolls *= 10;
			}

			Console.ReadKey();
		}

		// Display header for result table.
		private static void ReportHeader()
		{
			Console.WriteLine("# of Rolls 1s     2s     3s     4s     5s     6s    ");
			Console.WriteLine("====================================================");
		}

		// Takes in experiment result record and displays it.
		private static void ReportRow(int rolls, IDictionary<int, int> data)
		{
			Console.WriteLine(rolls.ToString().PadRight(10) + " "
					+ FormatData(rolls, data[1])
					+ FormatData(rolls, data[2])
					+ FormatData(rolls, data[3])
					+ FormatData(rolls, data[4])
					+ FormatData(rolls, data[5])
					+ FormatData(rolls, data[6])
				);
		}

		// Display formatted die value statistic.
		private static string FormatData(int rolls, int value)
		{
			double percent = (double)value / (double)rolls * 100D;
			return percent.ToString("00.00") + "% ";
		}
	}
}

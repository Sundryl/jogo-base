using System.Collections.Generic;
using System.Text;

namespace FantasyWorld.CharacterSystem
{
	public static class GovernmentOfficeBalanceReport
	{
		public static string Generate()
		{
			return null;
		}

		private static void AppendCentralIncomeSection(StringBuilder _report, List<State> _validStates)
		{
		}

		private static void AppendGovernorSection(StringBuilder _report, List<State> _validStates)
		{
		}

		private static void AppendDistrictGovernorSection(StringBuilder _report, List<State> _validStates)
		{
		}

		private static void AppendMilitarySection(StringBuilder _report, List<State> _validStates)
		{
		}

		private static void AppendHolderQuality(StringBuilder _report, string _label, List<State> _validStates, string _officeId)
		{
		}

		private static void AppendExtremes(StringBuilder _report, List<(string name, float multiplier)> _rows)
		{
		}

		private static IEnumerable<Province> CountedProvinces(State _state)
		{
			return null;
		}

		private static float AverageOrNeutral(IEnumerable<float> _values)
		{
			return 0f;
		}

		private static string FormatPercent(double _ratio)
		{
			return null;
		}

		private static string FormatRatio(int _numerator, int _denominator)
		{
			return null;
		}
	}
}

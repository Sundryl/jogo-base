using Unity.Profiling;

namespace FantasyWorld.CharacterSystem
{
	internal static class GovernmentOfficeProfiling
	{
		internal static readonly ProfilerMarker s_LookupMarker;

		internal static readonly ProfilerMarker s_EnsureDataMarker;

		internal static readonly ProfilerMarker s_EligibilityMarker;

		internal static readonly ProfilerMarker s_EffectsCentralIncomeMarker;

		internal static readonly ProfilerMarker s_EffectsLocalIncomeMarker;

		internal static readonly ProfilerMarker s_EffectsLocalRebellionMarker;

		internal static readonly ProfilerMarker s_EffectsAverageRebellionMarker;

		internal static readonly ProfilerMarker s_EffectsMilitaryLeaderMarker;

		internal static readonly ProfilerMarker s_AiProcessMonthlyMarker;

		internal static readonly ProfilerMarker s_AiReviewAnnualMarker;

		internal static readonly ProfilerMarker s_AiTryFillVacancyMarker;

		internal static readonly ProfilerMarker s_AiCandidateScoresMarker;

		internal static readonly ProfilerMarker s_AiFetchCharactersMarker;

		internal static readonly ProfilerMarker s_AiBuildIndexMarker;

		internal static readonly ProfilerMarker s_AiFilterCandidatesMarker;

		internal static readonly ProfilerMarker s_ServiceAppointMarker;

		internal static readonly ProfilerMarker s_ServiceReconcileMarker;

		internal static readonly ProfilerMarker s_ArmyLeadershipMarker;
	}
}

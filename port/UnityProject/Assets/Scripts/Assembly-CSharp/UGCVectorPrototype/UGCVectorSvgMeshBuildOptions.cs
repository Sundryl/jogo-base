namespace UGCVectorPrototype
{
	public struct UGCVectorSvgMeshBuildOptions
	{
		public bool buildFill;

		public bool buildStroke;

		public UGCVectorSvgImportOptions fillOptions;

		public UGCVectorSvgStrokeOptions strokeOptions;

		public static UGCVectorSvgMeshBuildOptions Default => default;

		public static UGCVectorSvgMeshBuildOptions FillOnly => default;
	}
}

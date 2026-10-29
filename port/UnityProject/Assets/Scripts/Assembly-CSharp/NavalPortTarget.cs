public readonly struct NavalPortTarget
{
	public int PortProvinceId { get; }

	public int TargetSeaCell { get; }

	public int TargetSeaProvinceId { get; }

	public bool IsValid => false;

	public static NavalPortTarget Invalid => default;

	public NavalPortTarget(int _portProvinceId, int _targetSeaCell, int _targetSeaProvinceId)
	{
		PortProvinceId = 0;
		TargetSeaCell = 0;
		TargetSeaProvinceId = 0;
	}
}

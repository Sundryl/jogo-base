public readonly struct MerchantShipSnapshot
{
	public int OwnerStateId { get; }

	public int HomePortProvinceId { get; }

	public int CurrentCell { get; }

	public float Health { get; }

	public int TradeTargetPortProvinceId { get; }

	public int PathIndex { get; }

	public int PathCount { get; }

	public float NextRouteReplanTime { get; }

	public int FailedRouteAttempts { get; }

	public float Speed { get; }

	public MerchantShipSnapshot(int _ownerStateId, int _homePortProvinceId, int _currentCell, float _health, int _tradeTargetPortProvinceId, int _pathIndex, int _pathCount, float _nextRouteReplanTime, int _failedRouteAttempts, float _speed)
	{
		OwnerStateId = 0;
		HomePortProvinceId = 0;
		CurrentCell = 0;
		Health = 0f;
		TradeTargetPortProvinceId = 0;
		PathIndex = 0;
		PathCount = 0;
		NextRouteReplanTime = 0f;
		FailedRouteAttempts = 0;
		Speed = 0f;
	}
}

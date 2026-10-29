using System.Collections.Generic;
using UnityEngine;

internal class MerchantShipRuntime
{
	public int ownerStateId;

	public int homePortProvinceId;

	public int homeSeaFeatureId;

	public int currentCell;

	public float health;

	public int tradeTargetPortProvinceId;

	public List<int> currentPath;

	public int pathIndex;

	public float nextRouteReplanTime;

	public int failedRouteAttempts;

	public readonly float speed;

	public GameObject gameObject;

	public SvgIconRenderer svgIconRenderer;
}

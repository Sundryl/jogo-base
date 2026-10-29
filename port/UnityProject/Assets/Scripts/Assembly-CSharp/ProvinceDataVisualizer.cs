using System.Collections.Generic;
using Shapes;
using UnityEngine;

public class ProvinceDataVisualizer : MonoBehaviour
{
	public enum VisualizerState
	{
		Off = 0,
		Population = 1,
		Economy = 2
	}

	private static ProvinceDataVisualizer instance;

	public Color ecnomicColor;

	public Color populationColor;

	private Dictionary<int, Disc> populationCircles;

	private Dictionary<int, Disc> economyCircles;

	private Queue<Disc> circlePool;

	private int initialPoolSize;

	private float maxPopulation;

	private float maxEconomy;

	private float minRadius;

	private float maxRadius;

	private VisualizerState currentState;

	public static ProvinceDataVisualizer Instance => null;

	private void Awake()
	{
	}

	private void InitializeObjectPool()
	{
	}

	private Disc CreateCircleObject()
	{
		return null;
	}

	private Disc GetCircleFromPool()
	{
		return null;
	}

	private void ReturnCircleToPool(Disc disc)
	{
	}

	public void SetState(VisualizerState state)
	{
	}

	private void UpdateVisibility()
	{
	}

	private void SetCirclesActive(Dictionary<int, Disc> circles, bool active)
	{
	}

	public void UpdateCircles()
	{
	}

	public void ClearCircles()
	{
	}

	private void ClearCircleSet(Dictionary<int, Disc> circles)
	{
	}

	private void ConfigureCircle(Disc disc, int provinceId, Vector3 position, float radius, Color color, string type)
	{
	}

	private void UpdateMaxValues()
	{
	}

	private float CalculateRadius(float value, float maxValue)
	{
		return 0f;
	}
}

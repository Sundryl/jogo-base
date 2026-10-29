using System.Collections.Generic;

public class BurgsAndStateGenerator
{
	private World world;

	private int totalStateCount;

	private State newState;

	public bool isGenBlankUnConquerableState;

	public BurgsAndStateGenerator(World world, int totalStateCount, State newState = null)
	{
	}

	public void Generate(bool isRegenerateProvince = true, bool isGenerateProvinceOnly = false)
	{
	}

	public void GenerateRouteOnly()
	{
	}

	public void GenerateForBiomOnly()
	{
	}

	public void RecalculateBurgPort()
	{
	}

	public void RegenerateSeaProvinceOnly()
	{
	}

	public void AddNewProvinceAndRegenerateSeaProvince(Province newProvince)
	{
	}

	private void InitEthnicAttribute()
	{
	}

	private void InitCultureNameSet(bool isRegenerateProvince)
	{
	}

	private List<BurgData> SelectCapitalsFromProvinces()
	{
		return null;
	}

	public void RecalculateProvinceState()
	{
	}

	public List<BurgData> PlaceCapitals()
	{
		return null;
	}

	public List<BurgData> PlaceProvincialCapitals()
	{
		return null;
	}

	public List<BurgData> PlaceProvincialCapitalsByJitterGrid()
	{
		return null;
	}

	public List<State> CreateStates()
	{
		return null;
	}

	public List<State> CreateStatesViaProvince()
	{
		return null;
	}

	public List<Province> CreateProvinces()
	{
		return null;
	}

	public List<Province> CreateSeaProvinces()
	{
		return null;
	}

	private void PlaceTowns()
	{
	}

	public static void FilterProvinceCells()
	{
	}

	private bool EnsureProvinceConnectivity()
	{
		return false;
	}

	private void ExpandStates()
	{
	}

	private void FilterProvincesNeedRecalAfterClickGen()
	{
	}

	private void ExpandProvinces()
	{
	}

	private void ExpandSeaProvinces()
	{
	}

	private void ExpandLandProvinces()
	{
	}

	private void ExpandStatesByProvince()
	{
	}

	private void CalculateStateNameWorldPos()
	{
	}

	private void NormalizeStates()
	{
	}

	private void SpecifyBurgAndProvince(bool isRegenerateProvince = true)
	{
	}

	private void RandomStateName()
	{
	}

	private void RandomProvinceName()
	{
	}

	public void RandomProvinceColors()
	{
	}

	private List<string> PickRandomCities(int amount)
	{
		return null;
	}

	public static State CreateBlankConquerableState()
	{
		return null;
	}

	public State CreateBlankUnConquerableState()
	{
		return null;
	}

	private void GenerateBlankUnConquerableStates()
	{
	}
}

using System.Collections.Generic;

public class Routes
{
	private World map;

	public Routes(World map)
	{
	}

	public List<List<int>> GetRoads()
	{
		return null;
	}

	public List<List<int>> RestorePath(int start, int end, string type, Dictionary<int, int> from)
	{
		return null;
	}

	public List<int> RestorePathNoRoad(int start, int end, string type, Dictionary<int, int> from)
	{
		return null;
	}

	public List<List<int>> GetTrails()
	{
		return null;
	}

	public List<List<int>> GetSeaRoutes()
	{
		return null;
	}

	public void FindLandPath(int start, int exit, bool toRoad, out Dictionary<int, int> from, out int targetExit)
	{
		from = null;
		targetExit = default;
	}

	private void addOverseaRoute(int f, int port)
	{
	}

	private bool FindOceanPath(int start, int exit, bool toRoute, out Dictionary<int, int> from, out int targetExit)
	{
		from = null;
		targetExit = default;
		return false;
	}
}

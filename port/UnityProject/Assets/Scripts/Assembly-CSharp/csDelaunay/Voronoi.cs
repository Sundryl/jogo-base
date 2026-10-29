using System.Collections.Generic;

namespace csDelaunay
{
	public class Voronoi
	{
		private SiteList sitelist;

		public List<Edge> edges;

		private List<Triangle> triangles;

		public Rectf PlotBounds { get; set; }

		public Dictionary<Vector2f, Site> SitesIndexedByLocation { get; private set; }

		public List<Site> Sites => null;

		public static int CompareByYThenX(Site s1, Site s2)
		{
			return 0;
		}

		public static int CompareByYThenX(Site s1, Vector2f s2)
		{
			return 0;
		}

		public Voronoi(List<Vector2f> points, Rectf plotBounds)
		{
		}

		public Voronoi(List<Vector2f> points, Rectf plotBounds, int lloydIterations)
		{
		}

		public void Dispose()
		{
		}

		public List<Vector2f> Region(Vector2f p)
		{
			return null;
		}

		public List<Vector2f> NeighborSitesForSite(Vector2f coord)
		{
			return null;
		}

		public List<LineSegment> VoronoiBoundaryForSite(Vector2f coord)
		{
			return null;
		}

		public List<LineSegment> VoronoiDiagram()
		{
			return null;
		}

		public List<Edge> HullEdges()
		{
			return null;
		}

		public List<Vector2f> HullPointsInOrder()
		{
			return null;
		}

		public List<List<Vector2f>> Regions()
		{
			return null;
		}

		public List<Circle> Circles()
		{
			return null;
		}

		public List<Vector2f> SiteCoords()
		{
			return null;
		}

		public void Update()
		{
		}

		private void FortunesAlgorithm()
		{
		}

		public void LloydRelaxation(int nbIterations)
		{
		}

		private void Init(List<Vector2f> points, Rectf plotBounds)
		{
		}

		private void PrepForUpdate()
		{
		}

		private void AddSites(List<Vector2f> points)
		{
		}

		private void AddSite(Vector2f p, int index)
		{
		}

		private void IndexSites(List<Site> sites)
		{
		}

		private Site LeftRegion(Halfedge he, Site bottomMostSite)
		{
			return null;
		}

		private Site RightRegion(Halfedge he, Site bottomMostSite)
		{
			return null;
		}
	}
}

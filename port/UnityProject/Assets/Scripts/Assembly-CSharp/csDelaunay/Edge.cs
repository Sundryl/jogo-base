using System.Collections.Generic;

namespace csDelaunay
{
	public class Edge
	{
		public static readonly Edge DELETED;

		private static Queue<Edge> pool;

		private static int nEdges;

		public float a;

		public float b;

		public float c;

		private Site leftSite;

		private Site rightSite;

		private readonly EdgeClippedVertices clippedVertices;

		private bool hasClippedVertices;

		public int EdgeIndex { get; private set; }

		public Vertex LeftVertex { get; private set; }

		public Vertex RightVertex { get; private set; }

		public EdgeClippedVertices ClippedVertices => null;

		public Site LeftSite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Site RightSite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsPartOfConvexHull => false;

		public bool Visible => false;

		public float SitesDistance => 0f;

		public static Edge CreateBisectingEdge(Site s0, Site s1)
		{
			return null;
		}

		private static Edge Create()
		{
			return null;
		}

		public static List<Edge> SelectEdgesForSitePoint(Vector2f coord, List<Edge> edgesToTest)
		{
			return null;
		}

		public static int CompareSitesDistances_MAX(Edge edge0, Edge edge1)
		{
			return 0;
		}

		public static int CompareSitesDistances(Edge edge0, Edge edge1)
		{
			return 0;
		}

		public void Dispose()
		{
		}

		public Vertex Vertex(LR leftRight)
		{
			return null;
		}

		public void SetVertex(LR leftRight, Vertex v)
		{
		}

		public Site Site(LR leftRight)
		{
			return null;
		}

		public LineSegment DelaunayLine()
		{
			return null;
		}

		public LineSegment VoronoiEdge()
		{
			return null;
		}

		public void ClipVertices(Rectf bounds)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private Edge Init()
		{
			return null;
		}
	}
}

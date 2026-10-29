using System.Collections.Generic;

namespace csDelaunay
{
	public class SiteList
	{
		private int currentIndex;

		private bool sorted;

		public List<Site> Sites { get; set; }

		public int Count => 0;

		public SiteList(int capacity = 0)
		{
		}

		public void Dispose()
		{
		}

		public void PrepForUpdate()
		{
		}

		public int Add(Site site)
		{
			return 0;
		}

		public Site Next()
		{
			return null;
		}

		public List<Vector2f> SiteCoords()
		{
			return null;
		}

		public Rectf GetSitesBounds()
		{
			return default;
		}

		public List<Circle> Circles()
		{
			return null;
		}

		public List<List<Vector2f>> Regions(Rectf plotBounds)
		{
			return null;
		}

		public void ResetListIndex()
		{
		}

		public void SortList()
		{
		}
	}
}

using System;
using System.Collections.Generic;
using Cogobyte.SmartProceduralIndicators.SmartArrowUtilities;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class Outline
	{
		public List<OutlineEdge> edges;

		public Color32 color;

		public List<MeshItem> backFaceMeshes;

		public List<MeshItem> frontFaceMeshes;

		public Outline()
		{
		}

		public Outline(Outline outline)
		{
		}

		public void CopyOutline(Outline outline)
		{
		}

		public void SetPointsColors(Color32 color)
		{
		}

		public void CalculateNormals()
		{
		}

		public void CalculateSmoothNormals()
		{
		}

		public void CalculateSmoothNormals(OutlineEdge targetEdge)
		{
		}

		public void FlipHorizontal()
		{
		}

		public void FlipVertical()
		{
		}

		public static void GenerateFaceMesh(MeshItem meshItem, Outline outline, bool front)
		{
		}

		public static void GenerateFaceMesh(Mesh mesh, Outline outline, bool front)
		{
		}

		public static void GenerateOutlineToOutlineFace(BodyTipMeshItem connector, Outline outer, Outline inner, bool tail)
		{
		}

		private static List<List<EarClipping.ColoredVertex>> FormOutlineList(Outline outline)
		{
			return null;
		}
	}
}

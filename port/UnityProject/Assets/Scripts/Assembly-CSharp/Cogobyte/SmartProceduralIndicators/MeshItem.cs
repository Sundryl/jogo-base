using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.SmartProceduralIndicators
{
	[Serializable]
	public class MeshItem
	{
		public enum MeshItemColorMode
		{
			InputColor = 0,
			SingleColor = 1,
			VertexColor = 2
		}

		[Min(0f)]
		public int meshIndex;

		public ArrowMesh mesh;

		public MeshItemColorMode colorMode;

		public Color color;

		public MeshItem()
		{
		}

		public MeshItem(MeshItem m)
		{
		}

		public void LoadMesh(Mesh inputMesh)
		{
		}

		public void AddToMesh(ArrowMesh destinationMesh, Vector3 position, Quaternion rotation, Vector3 size, Color32 color)
		{
		}

		public void AddToMeshInnerOuter(ArrowMesh destinationMesh, Vector3 pos, Quaternion rot, Vector3 innerSize, Vector3 outerSize, Color32 color, List<int> inner)
		{
		}
	}
}

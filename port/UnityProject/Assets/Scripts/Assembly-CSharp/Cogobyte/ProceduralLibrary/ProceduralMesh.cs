using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	public abstract class ProceduralMesh : ScriptableObject
	{
		public Vector3 position;

		public Vector3 rotation;

		public Vector3 scale;

		[NonSerialized]
		public Matrix4x4 transformOffset;

		[NonSerialized]
		public Mesh mesh;

		[NonSerialized]
		public int vertexCount;

		[NonSerialized]
		public int trisCount;

		[NonSerialized]
		public Vector3[] verts;

		[NonSerialized]
		public int[] tris;

		[NonSerialized]
		public Vector2[] uvs;

		[NonSerialized]
		public Color32[] colors;

		[NonSerialized]
		public Vector3[] normals;

		[NonSerialized]
		public List<int> doubleVerts;

		[NonSerialized]
		public List<int> doubleVertsSecond;

		public virtual int getVertexCount()
		{
			return 0;
		}

		public virtual int getTrisCount()
		{
			return 0;
		}

		public void prepareOffset()
		{
		}

		public void prepareMesh()
		{
		}

		public virtual void generate()
		{
		}

		public static void prepareColorGradient(ref Gradient[] gradient)
		{
		}

		protected void setMesh(string name)
		{
		}

		public void FixNormals()
		{
		}
	}
}

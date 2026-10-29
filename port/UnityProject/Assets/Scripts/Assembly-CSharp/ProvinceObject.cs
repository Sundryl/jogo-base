using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ProvinceObject : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CBlinkCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ProvinceObject _003C_003E4__this;

		private Material _003CoriginalMaterial_003E5__2;

		private Color _003CstateColor_003E5__3;

		private Color _003CwarColor_003E5__4;

		private float _003CtransitionTime_003E5__5;

		private float _003CcurrentTime_003E5__6;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CBlinkCoroutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private const string c_DynamicMeshNamePrefix = "DynamicProvinceMesh_";

	private static World map;

	private Renderer rend;

	public int provinceID;

	public bool isMeshInit;

	public bool isDebug;

	public bool IsAtWar;

	public int stateID;

	private Material battleBlinkMaterial;

	public Material provinceMaterial;

	public List<Vector3> vertices;

	public List<int> triangles;

	public List<Vector2> uvs;

	public List<Color> colors;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetMeshData(List<Vector3> vertices, List<int> triangles, List<Vector2> uvs, List<Color> colors)
	{
	}

	public void SetMesh(List<Vector3> vertices, List<int> triangles, List<Vector2> uvs, List<Color> colors)
	{
	}

	public bool HasRenderableMeshData()
	{
		return false;
	}

	public void RecreateRuntimeMesh()
	{
	}

	public void InitMesh()
	{
	}

	public void SetMaterial(Material material)
	{
	}

	public void Blink()
	{
	}

	[IteratorStateMachine(typeof(_003CBlinkCoroutine_003Ed__23))]
	private IEnumerator BlinkCoroutine()
	{
		return null;
	}

	internal void UpdateColors()
	{
	}

	private Mesh EnsureRuntimeMesh(MeshFilter meshFilter)
	{
		return null;
	}

	private Mesh CreateRuntimeMesh()
	{
		return null;
	}

	private void DestroyRuntimeMesh(Mesh mesh)
	{
	}

	private bool IsRuntimeMesh(Mesh mesh)
	{
		return false;
	}
}

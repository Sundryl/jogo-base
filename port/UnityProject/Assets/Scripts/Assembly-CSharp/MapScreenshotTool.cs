using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class MapScreenshotTool : MonoBehaviour
{
	public enum ImageFormat
	{
		PNG = 0,
		JPG = 1
	}

	public enum MapType
	{
		Current = 0,
		Biome = 1,
		Height = 2,
		State = 3,
		Religion = 4,
		Culture = 5
	}

	[Serializable]
	public class MapTypeConfig
	{
		public MapType Type;

		public string FileSuffix;

		public bool DefaultEnabled;

		public string DisplayName;
	}

	public delegate void ScreenshotCompleteHandler(string filePath);

	private class WorldState
	{
		public RenderTexture TargetTexture;

		public int CullingMask;

		public CameraClearFlags ClearFlags;

		public Color BackgroundColor;

		public Vector3 Position;

		public Quaternion Rotation;

		public bool IsOrthographic;

		public float OrthographicSize;

		public float FieldOfView;

		public bool IsGamePaused;

		public float IconDisplayDistance;

		public float UseHeightMapBackground;

		public float StateMapTransparency;

		public bool IsEnableAttackArrow;

		public float AttackArrowShowDistance;

		public bool IsDisplayArmy;

		public bool ManagedBattleSwordVisible;

		public Dictionary<int, List<bool>> BattleSwordStates;

		public ColorViewMode ColorViewMode;

		public int DrawProvinceMode;
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCaptureMapScreenshot_003Ed__44 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public string filename;

		public MapScreenshotTool _003C_003E4__this;

		public ImageFormat imageFormat;

		private string _003CfilePath_003E5__2;

		private RenderTexture _003CrenderTexture_003E5__3;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CWaitForBorderLineUpdate_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapType mapType;

		public float maxWaitTime;

		public MapScreenshotTool _003C_003E4__this;

		private float _003CelapsedTime_003E5__2;

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
		public _003CWaitForBorderLineUpdate_003Ed__59(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003CExportMapTypeCoroutine_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapScreenshotTool _003C_003E4__this;

		public MapType mapType;

		public string baseFilename;

		public ImageFormat imageFormat;

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
		public _003CExportMapTypeCoroutine_003Ed__61(int _003C_003E1__state)
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

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CSaveImageAsync_003Ed__76 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string filePath;

		public byte[] imageBytes;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[CompilerGenerated]
	private sealed class _003CExportMapCoroutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public MapScreenshotTool _003C_003E4__this;

		private string _003CoutputFolder_003E5__2;

		private string _003CbaseFilename_003E5__3;

		private IEnumerator _003C_003E7__wrap3;

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
		public _003CExportMapCoroutine_003Ed__79(int _003C_003E1__state)
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

		private void _003C_003Em__Finally1()
		{
		}

		private void _003C_003Em__Finally2()
		{
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private static MapScreenshotTool s_Instance;

	[SerializeField]
	[Header("相机设置")]
	private Camera m_MainCamera;

	[Header("截图设置")]
	[SerializeField]
	private LayerMask m_CaptureLayers;

	[SerializeField]
	private bool m_DisplayAttackArrow;

	[SerializeField]
	private bool m_DisplayArmy;

	[SerializeField]
	private bool m_DisplayBattleSword;

	[SerializeField]
	[Header("输出设置")]
	private int m_OutputWidth;

	[SerializeField]
	private int m_OutputHeight;

	[SerializeField]
	private string m_OutputFolder;

	[SerializeField]
	private TextureFormat m_TextureFormat;

	[Header("导出配置")]
	[SerializeField]
	private List<MapTypeConfig> m_MapConfigs;

	[Header("调试选项")]
	[SerializeField]
	private bool m_ShowDebugInfo;

	[SerializeField]
	private Color m_BackgroundColor;

	private Vector3 m_TargetPosition;

	private Quaternion m_TargetRotation;

	private float m_TargetOrthographicSize;

	private bool m_TargetOrthographic;

	private WorldState m_OriginalWorldState;

	private Dictionary<MapType, bool> m_EnabledMapTypes;

	private Dictionary<MapType, MapTypeConfig> m_MapTypeConfigDict;

	private bool m_IsExporting;

	private const int MAX_TEXTURE_SIZE = 16384;

	public static MapScreenshotTool Instance => null;

	public bool ShowDebugInfo => false;

	public bool IsExporting => false;

	public void SetOutputResolution(int width, int height)
	{
	}

	public Vector2Int GetOutputResolution()
	{
		return default;
	}

	public void SetDisplayAttackArrow(bool display)
	{
	}

	public void SetDisplayArmy(bool display)
	{
	}

	public bool GetDisplayAttackArrow()
	{
		return false;
	}

	public bool GetDisplayArmy()
	{
		return false;
	}

	public bool GetDisplayBattleSword()
	{
		return false;
	}

	private void Awake()
	{
	}

	private void InitializeMapConfigs()
	{
	}

	public void PositionCameraToFitTarget(GameObject targetObject)
	{
	}

	private Bounds GetActualMapBoundsWithFrames(GameObject targetObject)
	{
		return default;
	}

	private Bounds GetGameObjectBounds(GameObject obj)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCaptureMapScreenshot_003Ed__44))]
	public void CaptureMapScreenshot(string filename, ImageFormat imageFormat = ImageFormat.PNG)
	{
	}

	public static string GetDesktopPath()
	{
		return null;
	}

	public void SetOutputResolution(int size)
	{
	}

	private bool ValidateTextureSize(int size)
	{
		return false;
	}

	private void SetSafeResolution()
	{
	}

	public void SetOutputFolder(string folderName)
	{
	}

	public LayerMask GetAllLayersMask()
	{
		return default;
	}

	public void SetCaptureLayers(LayerMask layerMask)
	{
	}

	public void CacheWorldState()
	{
	}

	public void RestoreWorldState()
	{
	}

	public void ApplyScreenshotSettings()
	{
	}

	public void DisableAllHighlights()
	{
	}

	public void SetMapTypeEnabled(MapType mapType, bool enabled)
	{
	}

	public bool IsMapTypeEnabled(MapType mapType)
	{
		return false;
	}

	public void SwitchToMapType(MapType mapType)
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForBorderLineUpdate_003Ed__59))]
	private IEnumerator WaitForBorderLineUpdate(MapType mapType, float maxWaitTime = 5f)
	{
		return null;
	}

	public void ExportMapTypeAsync(string baseFilename, MapType mapType, ImageFormat imageFormat = ImageFormat.PNG)
	{
	}

	[IteratorStateMachine(typeof(_003CExportMapTypeCoroutine_003Ed__61))]
	private IEnumerator ExportMapTypeCoroutine(string baseFilename, MapType mapType, ImageFormat imageFormat)
	{
		return null;
	}

	public void ExportMapType(string baseFilename, MapType mapType, ImageFormat imageFormat = ImageFormat.PNG)
	{
	}

	public string GetFileSuffixForMapType(MapType mapType)
	{
		return null;
	}

	public void SetDisplayBattleSword(bool display)
	{
	}

	private void SetAllBattleSwordsVisibility(bool isVisible)
	{
	}

	public void SetDynamicElementsVisibility(bool showTempElements)
	{
	}

	private void SetUITemporaryElementsVisibility(bool showElements)
	{
	}

	private void AdjustOutputResolutionToMatchAspectRatio(float objectWidth, float objectHeight)
	{
	}

	private Bounds CalculateBoundsFromChildren(GameObject parent)
	{
		return default;
	}

	private RenderTexture CaptureToRenderTexture()
	{
		return null;
	}

	private WorldState SaveWorldState(Camera camera)
	{
		return null;
	}

	private void RestoreWorldState(Camera camera, WorldState state)
	{
	}

	private void ApplyCameraSettingsForScreenshot(Camera camera)
	{
	}

	private byte[] ConvertRenderTextureToBytes(RenderTexture renderTexture, ImageFormat imageFormat)
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CSaveImageAsync_003Ed__76))]
	private Task SaveImageAsync(byte[] imageBytes, string filePath)
	{
		return null;
	}

	public void ExportMap()
	{
	}

	private void RefreshAllBurgIconVisibility()
	{
	}

	[IteratorStateMachine(typeof(_003CExportMapCoroutine_003Ed__79))]
	private IEnumerator ExportMapCoroutine()
	{
		return null;
	}
}

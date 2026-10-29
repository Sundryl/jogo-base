using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

internal class PlayerController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CMoveToNextLocation_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerController _003C_003E4__this;

		private Vector3 _003CstartPosition_003E5__2;

		private Vector3 _003CtargetPosition_003E5__3;

		private float _003Cduration_003E5__4;

		private float _003CelapsedTime_003E5__5;

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
		public _003CMoveToNextLocation_003Ed__50(int _003C_003E1__state)
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
	private sealed class _003CDelayedRedraw_003Ed__73 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerController _003C_003E4__this;

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
		public _003CDelayedRedraw_003Ed__73(int _003C_003E1__state)
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
	private sealed class _003CRedrawProvinceBorder_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public PlayerController _003C_003E4__this;

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
		public _003CRedrawProvinceBorder_003Ed__76(int _003C_003E1__state)
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
	private sealed class _003CPlayArmySpawnAnimation_003Ed__83 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Army _army;

		private float _003Cduration_003E5__2;

		private float _003CstartScale_003E5__3;

		private float _003CtargetScale_003E5__4;

		private float _003Celapsed_003E5__5;

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
		public _003CPlayArmySpawnAnimation_003Ed__83(int _003C_003E1__state)
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
	private sealed class _003CUpdateArrowAnim_003Ed__88 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Transform currentArrow;

		public Color ArrowColor;

		private float _003CupdateTimeSum_003E5__2;

		private float _003CarrowDisplacement_003E5__3;

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
		public _003CUpdateArrowAnim_003Ed__88(int _003C_003E1__state)
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

	private static PlayerController _instance;

	public int firstSelectedStateIndex;

	public int secondSelectedStateIndex;

	private Transform currentArrow;

	private Transform target;

	private bool isFollowing;

	public DouyinHelper Helper;

	public Input input;

	private int m_DistrictCountAtDrawStart;

	private bool m_DistrictMembershipChangedDuringStroke;

	public LayerMask layerMask;

	public LayerMask armyMask;

	public float smoothSpeed;

	public Vector3 offset;

	public bool isDrawing;

	private float cameraMovementSpeed;

	public bool isEnableCameraFollow;

	private Army armyLastHovered;

	public EnumBrushHeightModifyMode currentBrushMode;

	private EnumBrushShapeType currentBrushShape;

	private HashSet<int> provinceNeedUpdate;

	public LeftClickAction currentLeftClickAction;

	public GameObject rightClickMenu;

	private bool isDragging;

	private Vector3 initialMousePosition;

	private float timeRightMouseDown;

	private float movementThreshold;

	private float timeThreshold;

	private Vector3 dragOrigin;

	public float arrowDisplacement;

	public float MovementSpeed;

	public float ZoomSpeed;

	public float ZoomMin;

	public float ZoomMax;

	public Camera mainCamera;

	private Queue<Vector3> targetLocations;

	private bool isMoving;

	private float redrawDelay;

	private Coroutine redrawCoroutine;

	private Coroutine redrawProvinceBorderCoroutine;

	public static PlayerController Instance => null;

	private void LateUpdate()
	{
	}

	public void StartFollowing(Transform armyTransform)
	{
	}

	public void StopFollowing()
	{
	}

	private void Start()
	{
	}

	private void CameraMovement()
	{
	}

	private void PauseGame()
	{
	}

	private bool IsInputFieldActive()
	{
		return false;
	}

	private void Update()
	{
	}

	private void DebugViewModeSwitch()
	{
	}

	private void DebugDouyinCommand()
	{
	}

	private void SetDisplayIndex(int index)
	{
	}

	private void HandleDisableAllProvinceCommand()
	{
	}

	private void HandleEnableAllProvinceCommand()
	{
	}

	private void HanldeRandomFireballCommand()
	{
	}

	private void HandleRandomStateEliminationCommand()
	{
	}

	private void HandleDeclareRandomWinnerCommand()
	{
	}

	private void HandleJoinStateCommand()
	{
	}

	private void HandleRandomRebelCommand()
	{
	}

	private void HandleRandomAllianceCommand()
	{
	}

	private void HandleRandomPeaceCommand()
	{
	}

	private void HandleDestinyAndCavalryTraitsCommand()
	{
	}

	private void HandleMilitaryTraitsCommand()
	{
	}

	private void HandleAllTraitsCommand()
	{
	}

	private void HanldeAllDestinyCommand()
	{
	}

	private void HandlePlace10ArmiesCommand()
	{
	}

	private void HandlePlace30ArmiesCommand()
	{
	}

	private int GetRandomValidStateIndex()
	{
		return 0;
	}

	private void EscKeyLogic()
	{
	}

	private void DrawMapHeightLogic()
	{
	}

	private void CameraFollowLogic()
	{
	}

	public void MoveToLocation(Vector3 location)
	{
	}

	[IteratorStateMachine(typeof(_003CMoveToNextLocation_003Ed__50))]
	private IEnumerator MoveToNextLocation()
	{
		return null;
	}

	private void MouseHoverLogic()
	{
	}

	private void LeftClickLogic()
	{
	}

	private void MakeVassal(int firstSelectedStateIndex, int secondSelectedStateIndex)
	{
	}

	private void RemoveArmy(Vector3 pos)
	{
	}

	private void AddProvince(int cellIndex)
	{
	}

	private void PlaceBlankState(int cellIndex)
	{
	}

	private void SetProvinceToDraw(int provinceID)
	{
	}

	public void DrawProvince(int centerCell)
	{
	}

	public void DrawState(int centerCell)
	{
	}

	public void DrawBlankConquerableState(int centerCell)
	{
	}

	public void DrawDistrict(int centerCell)
	{
	}

	public void DrawBlankUnConquerableState(int centerCell)
	{
	}

	public void PlaceHill(int centerCell)
	{
	}

	private void DrawMapHeight(Vector3 pos)
	{
	}

	private void DrawCulture(int centerCell)
	{
	}

	private void DrawReligion(int centerCell)
	{
	}

	private void DrawFamily(int centerCell)
	{
	}

	private void DrawBiom(Vector3 pos)
	{
	}

	private void TriggerDelayedRedraw()
	{
	}

	[IteratorStateMachine(typeof(_003CDelayedRedraw_003Ed__73))]
	private IEnumerator DelayedRedraw()
	{
		return null;
	}

	private void TriggerRedrawProvinceBorder(HashSet<int> provinces)
	{
	}

	[IteratorStateMachine(typeof(_003CRedrawProvinceBorder_003Ed__76))]
	private IEnumerator RedrawProvinceBorder()
	{
		return null;
	}

	public void PlaceNewRandomState(int cell)
	{
	}

	public void PlaceStateFinal(int cell, State state)
	{
	}

	public void PlaceCurrentState(int cell)
	{
	}

	public void PlaceState(int cell, State state)
	{
	}

	public void PlaceArmy(int cell, State state)
	{
	}

	public void PlaceArmyInAllProvince(int cell, State state, int armyCount)
	{
	}

	[IteratorStateMachine(typeof(_003CPlayArmySpawnAnimation_003Ed__83))]
	public IEnumerator PlayArmySpawnAnimation(Army _army)
	{
		return null;
	}

	private void StartWar(int firstSelectedStateIndex, int secondSelectedStateIndex)
	{
	}

	private void AnnexSelectedState(int conquerorStateIndex, int conqueredStateIndex)
	{
	}

	private void StopWar(int firstSelectedStateIndex, int secondSelectedStateIndex)
	{
	}

	private void StartAlliance(int firstSelectedStateIndex, int secondSelectedStateIndex)
	{
	}

	[IteratorStateMachine(typeof(_003CUpdateArrowAnim_003Ed__88))]
	private IEnumerator UpdateArrowAnim(Transform currentArrow, Color ArrowColor)
	{
		return null;
	}

	private void LogProvinceInfo(int cellID)
	{
	}

	private void ForceRebel(CellObject cellObject)
	{
	}

	private void RightClickLogic()
	{
	}

	private void ShowRightClickMenu(Vector3 position)
	{
	}

	private void UpdateAttackArrow(Vector3 startPos, Vector3 endPos)
	{
	}

	private void ResetSelection()
	{
	}

	internal void DrawAttackArrowAnim(State state, State warTarget)
	{
	}

	public void DrawVassalArrowAnim(State vassalState, State overlordState)
	{
	}

	public void ClearTemporaryUIElements()
	{
	}
}

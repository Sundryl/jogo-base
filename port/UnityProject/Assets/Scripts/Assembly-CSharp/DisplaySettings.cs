using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Michsky.MUIP;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

internal class DisplaySettings : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	[CompilerGenerated]
	private sealed class _003CBackToCustom_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisplaySettings _003C_003E4__this;

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
		public _003CBackToCustom_003Ed__4(int _003C_003E1__state)
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
	private sealed class _003CRefreshLayout_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public DisplaySettings _003C_003E4__this;

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
		public _003CRefreshLayout_003Ed__59(int _003C_003E1__state)
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

	private static DisplaySettings _instance;

	public int currentPresetIndex;

	public bool isPresetStyleSwitching;

	public ButtonManager DisplaySwitchButton;

	public List<DisplayPreset> displayPresets;

	public Image DeepSeaColorImage;

	public Image ShallowSeaColorImage;

	public Image SeaRouteColorImage;

	public Image StateLineColorImage;

	public Image CoastLineColorImage;

	public Image StateNameColorImage;

	public Image ProvinceBorderColorImage;

	public Slider StateBorderWidthSlider;

	public Slider CoastBorderWidthSlider;

	public Slider DarkBorderShadowWidthSlider;

	public Slider StateNameScaleSlider;

	public Slider IconDisplayDistanceSlider;

	public Slider AttackArrowDisplayDistanceSlider;

	public Slider BurgCityLabelScaleSlider;

	public Slider ArmyLabelScaleSlider;

	public Slider StateMapTransparencySlider;

	public SwitchManager DisplayBiomHeightMapToggle;

	public TextMeshProUGUI BiomHeightMapDisplayText;

	public SwitchManager DisplayArmyToggle;

	public SwitchManager DisplayAttackArrowToggle;

	public SwitchManager DisplayBurgNameToggle;

	public SwitchManager DisplayBurgObjectToggle;

	public SwitchManager DispalyPachmentToggle;

	public SwitchManager DispalyPachmentTextureToggle;

	public SwitchManager DisplayDarkBorderToggle;

	public SwitchManager DisplayFullNameToggle;

	public SwitchManager DisplayPopulationToggle;

	public SwitchManager DisplayProvinceBorderToggle;

	public SwitchManager DisplaySeaRouteToggle;

	public SwitchManager AutoHideBottomPanelToggle;

	public SwitchManager IsRandomStyleToggle;

	public SwitchManager IsDisplayTimeToggle;

	public SwitchManager IsDisplayMajorEventToggle;

	public SwitchManager IsEnableMapCoordinateToggle;

	public SwitchManager IsEnableBiomeIconToggle;

	public static DisplaySettings Instance => null;

	public void SwitchToNextPreset()
	{
	}

	[IteratorStateMachine(typeof(_003CBackToCustom_003Ed__4))]
	private IEnumerator BackToCustom()
	{
		return null;
	}

	public void ApplyCurrentPreset()
	{
	}

	public void ApplyRandomStyle()
	{
	}

	public void SwitchToCustomMode()
	{
	}

	private void UpdateModeButton()
	{
	}

	private void UpdateUIElements()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void BringToFront()
	{
	}

	public void InitDisplayInfo()
	{
	}

	public void RefreshLocalization()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnDisplayTimeToggleValueChanged(bool isOn)
	{
	}

	public void OnDisplayMesaageToggleValueChanged(bool isOn)
	{
	}

	[IteratorStateMachine(typeof(_003CRefreshLayout_003Ed__59))]
	private IEnumerator RefreshLayout()
	{
		return null;
	}

	public void OnBorderShadowWidthValueChanged(float value)
	{
	}

	public void OnDisplayAttackArrowValueChanged(bool isOn)
	{
	}

	public void OnStateNameScaleValueChanged(float value)
	{
	}

	public void OnBurgCityLabelScaleValueChanged(float value)
	{
	}

	public void OnArmyLabelScaleValueChanged(float value)
	{
	}

	public void OnIconDisplayDistanceValueChanged(float value)
	{
	}

	public void OnDisplayAttackArrowValueChanged(float value)
	{
	}

	public void OnDisPlayHeightMapToggleValueChanged(bool isOn)
	{
	}

	public void OnStateMapToggleValueChanged(bool isOn)
	{
	}

	public void OnPopulationToggleValueChanged(bool isOn)
	{
	}

	public void OnStateMapTransparentValueChanged(float Transparent)
	{
	}

	public void OnDarkBorderEnabled(bool isOn)
	{
	}

	public void OnDisPlayBiomMapToggleValueChanged(bool isOn)
	{
	}

	public void OnPachmentToggleValueChanged(bool isOn)
	{
	}

	public void OnProvinceBorderToggleValueChanged(bool isOn)
	{
	}

	public void OnDisplaySeaRouteToggleValueChanged(bool isOn)
	{
	}

	public void OnFullNameToggleValueChanged(bool isOn)
	{
	}

	public void OnAutoHideBottomPanelToggleValueChanged(bool isOn)
	{
	}

	public void OnPachmentTextureToggleValueChanged(bool isOn)
	{
	}

	public void OnDisplayBurgNameToggleValueChanged(bool isOn)
	{
	}

	public void OnDisplayArmyToggleValueChanged(bool isOn)
	{
	}

	public void OnDisplayBurgObjectToggleValueChanged(bool isOn)
	{
	}

	public void OnIsRandomStyleToggleValueChanged(bool isOn)
	{
	}

	public void OnMapCoordinateToggleValueChanged(bool isOn)
	{
	}

	public void OnEnableBiomeIconToggleValueChanged(bool isOn)
	{
	}

	public int GetCurrentDrawProvinceMode()
	{
		return 0;
	}
}

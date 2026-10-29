using TMPro;
using UnityEngine;

namespace Michsky.MUIP
{
	[CreateAssetMenu(fileName = "New UI Manager", menuName = "Modern UI Pack/New UI Manager")]
	public class UIManager : ScriptableObject
	{
		public enum ModalWindowThemeType
		{
			Basic = 0,
			Custom = 1
		}

		public enum NotificationThemeType
		{
			Basic = 0,
			Custom = 1
		}

		public enum SliderThemeType
		{
			Basic = 0,
			Custom = 1
		}

		public enum ToggleThemeType
		{
			Basic = 0,
			Custom = 1
		}

		[HideInInspector]
		public bool enableDynamicUpdate;

		[HideInInspector]
		public bool enableExtendedColorPicker;

		[HideInInspector]
		public bool editorHints;

		public Color animatedIconColor;

		public Color contextBackgroundColor;

		public TMP_FontAsset buttonFont;

		public Color buttonNormalColor;

		public Color buttonAccentColor;

		[Range(0f, 1f)]
		public float buttonDisabledAlpha;

		public TMP_FontAsset dropdownFont;

		public TMP_FontAsset dropdownItemFont;

		public Color dropdownBackgroundColor;

		public Color dropdownContentBackgroundColor;

		public Color dropdownPrimaryColor;

		public Color dropdownItemBackgroundColor;

		public Color dropdownItemPrimaryColor;

		public TMP_FontAsset selectorFont;

		public Color selectorColor;

		public Color selectorHighlightedColor;

		public TMP_FontAsset inputFieldFont;

		public Color inputFieldColor;

		public TMP_FontAsset modalWindowTitleFont;

		public TMP_FontAsset modalWindowContentFont;

		public Color modalWindowTitleColor;

		public Color modalWindowDescriptionColor;

		public Color modalWindowIconColor;

		public Color modalWindowBackgroundColor;

		public Color modalWindowContentPanelColor;

		public TMP_FontAsset notificationTitleFont;

		public float notificationTitleFontSize;

		public TMP_FontAsset notificationDescriptionFont;

		public float notificationDescriptionFontSize;

		public NotificationThemeType notificationThemeType;

		public Color notificationBackgroundColor;

		public Color notificationTitleColor;

		public Color notificationDescriptionColor;

		public Color notificationIconColor;

		public TMP_FontAsset progressBarLabelFont;

		public float progressBarLabelFontSize;

		public Color progressBarColor;

		public Color progressBarBackgroundColor;

		public Color progressBarLoopBackgroundColor;

		public Color progressBarLabelColor;

		public Color scrollbarColor;

		public Color scrollbarBackgroundColor;

		public TMP_FontAsset sliderLabelFont;

		public SliderThemeType sliderThemeType;

		public Color sliderColor;

		public Color sliderBackgroundColor;

		public Color sliderLabelColor;

		public Color sliderPopupLabelColor;

		public Color sliderHandleColor;

		public Color switchBorderColor;

		public Color switchBackgroundColor;

		public Color switchHandleOnColor;

		public Color switchHandleOffColor;

		public TMP_FontAsset toggleFont;

		public ToggleThemeType toggleThemeType;

		public Color toggleTextColor;

		public Color toggleBorderColor;

		public Color toggleBackgroundColor;

		public Color toggleCheckColor;

		public TMP_FontAsset tooltipFont;

		public float tooltipFontSize;

		public Color tooltipTextColor;

		public Color tooltipBackgroundColor;

		public TMP_FontAsset customObjPrimaryFont;

		public TMP_FontAsset customObjSecondaryFont;

		public Color customObjPrimaryColor;

		public Color customObjSecondaryColor;
	}
}

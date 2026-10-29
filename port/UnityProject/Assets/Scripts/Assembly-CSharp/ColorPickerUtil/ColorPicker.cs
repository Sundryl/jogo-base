using UnityEngine;
using UnityEngine.UI;

namespace ColorPickerUtil
{
	public class ColorPicker : MonoBehaviour
	{
		public enum Mode
		{
			HSV_H = 0,
			HSV_S = 1,
			HSV_V = 2,
			RGB_R = 3,
			RGB_G = 4,
			RGB_B = 5,
			Lab_L = 6,
			Lab_a = 7,
			Lab_b = 8
		}

		[SerializeField]
		private Mode mode;

		[SerializeField]
		private Image newColorImage;

		[SerializeField]
		private Image currentColorImage;

		[Header("Picking Components")]
		[SerializeField]
		private PickArea pickArea;

		[SerializeField]
		private PickBar pickBar;

		[SerializeField]
		private Slider alphaSlider;

		[SerializeField]
		private Eyedropper eyedropper;

		[SerializeField]
		private ColorSwatch colorSwatch;

		[SerializeField]
		[Header("Input Fields")]
		private InputField input_HSV_H;

		[SerializeField]
		private InputField input_HSV_S;

		[SerializeField]
		private InputField input_HSV_V;

		[SerializeField]
		private InputField input_RGB_R;

		[SerializeField]
		private InputField input_RGB_G;

		[SerializeField]
		private InputField input_RGB_B;

		[SerializeField]
		private InputField input_Lab_L;

		[SerializeField]
		private InputField input_Lab_a;

		[SerializeField]
		private InputField input_Lab_b;

		[SerializeField]
		private InputField input_CMYK_C;

		[SerializeField]
		private InputField input_CMYK_M;

		[SerializeField]
		private InputField input_CMYK_Y;

		[SerializeField]
		private InputField input_CMYK_K;

		[SerializeField]
		private InputField input_Hex;

		[SerializeField]
		private InputField input_Alpha;

		[Header("Mode Toggles")]
		[SerializeField]
		private Toggle toggle_HSV_H;

		[SerializeField]
		private Toggle toggle_HSV_S;

		[SerializeField]
		private Toggle toggle_HSV_V;

		[SerializeField]
		private Toggle toggle_RGB_R;

		[SerializeField]
		private Toggle toggle_RGB_G;

		[SerializeField]
		private Toggle toggle_RGB_B;

		[SerializeField]
		private Toggle toggle_Lab_L;

		[SerializeField]
		private Toggle toggle_Lab_a;

		[SerializeField]
		private Toggle toggle_Lab_b;

		[Header("End Pick Events")]
		[SerializeField]
		private Button endPickButton;

		public ColorPickerColorEvent onEndPick;

		[SerializeField]
		private Button cancelButton;

		public ColorPickerColorEvent onCancel;

		public ColorPickerColorEvent onNewColorValueChange;

		private bool inputFieldLock;

		private bool pickBarLock;

		private bool pickAreaLock;

		private float m_alpha;

		private ColorHSV m_newColorHSV;

		private ColorLab m_newColorLab;

		private ColorHex m_newColorHex;

		private ColorCMYK m_newColorCMYK;

		private Color m_newColor;

		private Color m_currentColor;

		public ColorHSV newColorHSV
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ColorLab newColorLab
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ColorHex newColorHex
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ColorCMYK newColorCMYK
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color newColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public Color currentColor
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public void Close()
		{
		}

		private void Awake()
		{
		}

		private void Initialize()
		{
		}

		private void SetNewColor(Color color)
		{
		}

		private void SetNewColorHSV(ColorHSV colorHSV)
		{
		}

		private void SetNewColorLab(ColorLab colorLab)
		{
		}

		private void SetNewColorCMYK(ColorCMYK colorCMYK)
		{
		}

		private void SetNewColorHex(ColorHex colorHex)
		{
		}

		private void SetPickedColor(Vector2 pickAreaValue, float pickBarValue)
		{
		}

		private void RefreshInputField()
		{
		}

		private void RefreshPicker()
		{
		}

		public void SetMode(Mode mode)
		{
		}

		private void OnToggleValueChangedHSV_H(bool isOn)
		{
		}

		private void OnToggleValueChangedHSV_S(bool isOn)
		{
		}

		private void OnToggleValueChangedHSV_V(bool isOn)
		{
		}

		private void OnToggleValueChangedRGB_R(bool isOn)
		{
		}

		private void OnToggleValueChangedRGB_G(bool isOn)
		{
		}

		private void OnToggleValueChangedRGB_B(bool isOn)
		{
		}

		private void OnToggleValueChangedLab_L(bool isOn)
		{
		}

		private void OnToggleValueChangedLab_a(bool isOn)
		{
		}

		private void OnToggleValueChangedLab_b(bool isOn)
		{
		}

		private void OnAlphaSliderChanged(float value)
		{
		}

		private void OnPickAreaChanged(Vector2 value)
		{
		}

		private void OnPickBarChanged(float value)
		{
		}

		private void OnEyedropperChanged(Color value)
		{
		}

		private void OnInputValueChangedHSV_H(string str)
		{
		}

		private void OnInputValueChangedHSV_S(string str)
		{
		}

		private void OnInputValueChangedHSV_V(string str)
		{
		}

		private void OnInputValueChangedRGB_R(string str)
		{
		}

		private void OnInputValueChangedRGB_G(string str)
		{
		}

		private void OnInputValueChangedRGB_B(string str)
		{
		}

		private void OnInputValueChangedLab_L(string str)
		{
		}

		private void OnInputValueChangedLab_a(string str)
		{
		}

		private void OnInputValueChangedLab_b(string str)
		{
		}

		private void OnInputValueChangedCMYK_C(string str)
		{
		}

		private void OnInputValueChangedCMYK_M(string str)
		{
		}

		private void OnInputValueChangedCMYK_Y(string str)
		{
		}

		private void OnInputValueChangedCMYK_K(string str)
		{
		}

		private void OnInputValueChangedHex(string str)
		{
		}

		private void OnInputValueChangedAlpha(string str)
		{
		}

		private void OnInputEndEditHSV_H(string str)
		{
		}

		private void OnInputEndEditHSV_S(string str)
		{
		}

		private void OnInputEndEditHSV_V(string str)
		{
		}

		private void OnInputEndEditRGB_R(string str)
		{
		}

		private void OnInputEndEditRGB_G(string str)
		{
		}

		private void OnInputEndEditRGB_B(string str)
		{
		}

		private void OnInputEndEditLab_L(string str)
		{
		}

		private void OnInputEndEditLab_a(string str)
		{
		}

		private void OnInputEndEditLab_b(string str)
		{
		}

		private void OnInputEndEditCMYK_C(string str)
		{
		}

		private void OnInputEndEditCMYK_M(string str)
		{
		}

		private void OnInputEndEditCMYK_Y(string str)
		{
		}

		private void OnInputEndEditCMYK_K(string str)
		{
		}

		private void OnInputEndEditHex(string str)
		{
		}

		private void OnInputEndEditAlpha(string str)
		{
		}
	}
}

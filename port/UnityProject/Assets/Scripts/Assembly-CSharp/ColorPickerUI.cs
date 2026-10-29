using ColorPickerUtil;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ColorPickerUI : MonoBehaviour
{
	public Image colorPickerImage;

	public ColorPickingButton colorPickerButton;

	private void Start()
	{
	}

	public void SetOnColorChangeCallback(UnityAction<Color> callback)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}
}

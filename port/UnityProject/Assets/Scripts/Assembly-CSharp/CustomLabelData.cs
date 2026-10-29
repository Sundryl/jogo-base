using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[Serializable]
public class CustomLabelData
{
	public string Id;

	public string Text;

	public Dictionary<string, string> TranslatedTexts;

	public float FontSize;

	public float LocalPosX;

	public float LocalPosY;

	public bool Visible;

	public int Version;

	public ColorData LabelColor;

	public ColorData OutlineColor;

	public float OutlineWidth;

	public bool UsePathLayout;

	public List<float> PathPointXs;

	public List<float> PathPointYs;

	public TextOrientation TextOrientation;

	public bool Italic;

	public bool Bold;

	public string FontId;

	[JsonIgnore]
	public List<Vector2> PathPoints
	{
		get
		{
			return null;
		}
		set
		{
		}
	}
}

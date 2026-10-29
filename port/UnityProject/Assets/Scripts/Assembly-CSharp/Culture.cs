using System;
using Newtonsoft.Json;
using UnityEngine;

public class Culture
{
	public int i;

	[JsonIgnore]
	public Color color;

	public string colorString;

	public string type;

	public float expansionism;

	public string code;

	public int center;

	public string Name { get; set; }

	public int Base { get; set; }

	public double Odd { get; set; }

	[JsonIgnore]
	public Func<int, double> Sort { get; set; }

	public string Shield { get; set; }
}

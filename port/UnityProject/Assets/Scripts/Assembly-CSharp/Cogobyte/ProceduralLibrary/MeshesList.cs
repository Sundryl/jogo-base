using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "MeshesList", menuName = "Cogobyte/ProceduralLibrary/3DMeshes/MeshesList", order = 1)]
	public class MeshesList : ScriptableObject
	{
		public List<ProceduralMesh> meshesList;
	}
}

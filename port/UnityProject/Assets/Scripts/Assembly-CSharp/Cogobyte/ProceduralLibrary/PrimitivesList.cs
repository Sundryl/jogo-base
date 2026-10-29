using System;
using System.Collections.Generic;
using UnityEngine;

namespace Cogobyte.ProceduralLibrary
{
	[Serializable]
	[CreateAssetMenu(fileName = "PrimitiveList", menuName = "Cogobyte/ProceduralLibrary/Primitives/PrimitiveList", order = 1)]
	public class PrimitivesList : ScriptableObject
	{
		public List<Primitive> primitivesList;
	}
}

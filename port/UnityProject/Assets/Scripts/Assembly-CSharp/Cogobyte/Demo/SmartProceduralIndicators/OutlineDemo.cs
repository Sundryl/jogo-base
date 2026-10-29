using System.Collections;
using System.Collections.Generic;
using Cogobyte.SmartProceduralIndicators;
using UnityEngine;

namespace Cogobyte.Demo.SmartProceduralIndicators
{
	public class OutlineDemo : MonoBehaviour
	{
		public SmartArrow mainArrow;

		public List<BodyRenderer> bodyRenderers;

		public List<ArrowTip> tails;

		public List<ArrowTip> heads;

		public SmartArrow[] shapeArrows;

		private int currentBody;

		private int currentTail;

		private int currentHead;

		private BodyTipMeshItem tailConnector;

		private BodyTipMeshItem headConnector;

		private float moveAmount;

		public float Speed;

		private float[] MoveAmountLeft;

		private float rotateAngle;

		private void Start()
		{
		}

		public void InitializeShapesArrow(ShapesBodyRenderer s, IEnumerable sourceTemplates, Vector3 shapeScale)
		{
		}

		public void PreviosBody()
		{
		}

		public void NextBody()
		{
		}

		public void PreviosTail()
		{
		}

		public void NextTail()
		{
		}

		public void PreviosHead()
		{
		}

		public void NextHead()
		{
		}

		public void SwitchBody()
		{
		}

		private void Update()
		{
		}
	}
}

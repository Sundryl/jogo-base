using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Michsky.MUIP
{
	public class PieChart : MaskableGraphic
	{
		[Serializable]
		public class PieChartDataNode
		{
			public string name;

			public float value;

			public Color32 color;

			public Image indicatorImage;

			public TextMeshProUGUI indicatorText;
		}

		[CompilerGenerated]
		private sealed class _003CUpdateIndicatorLayout_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PieChart _003C_003E4__this;

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
			public _003CUpdateIndicatorLayout_003Ed__19(int _003C_003E1__state)
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

		[SerializeField]
		public List<PieChartDataNode> chartData;

		[Range(-75f, 150f)]
		public float borderThickness;

		[SerializeField]
		private Color borderColor;

		public Transform indicatorParent;

		public string valuePrefix;

		public string valueSuffix;

		public bool addValueToIndicator;

		public bool enableBorderColor;

		private float fillAmount;

		private int segments;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		public void SetData(List<PieChartDataNode> data)
		{
		}

		protected UIVertex[] SetVbo(Vector2[] vertices, Vector2[] uvs, Color32 color)
		{
			return null;
		}

		public void UpdateIndicators()
		{
		}

		public void ChangeValue(int itemIndex, float itemValue)
		{
		}

		public void AddNewItem()
		{
		}

		[IteratorStateMachine(typeof(_003CUpdateIndicatorLayout_003Ed__19))]
		private IEnumerator UpdateIndicatorLayout()
		{
			return null;
		}
	}
}

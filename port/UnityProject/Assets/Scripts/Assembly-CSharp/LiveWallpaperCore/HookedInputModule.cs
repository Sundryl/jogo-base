using UnityEngine.EventSystems;

namespace LiveWallpaperCore
{
	public class HookedInputModule : StandaloneInputModule
	{
		private readonly MouseState mouseState;

		private void Update()
		{
		}

		public override bool ShouldActivateModule()
		{
			return false;
		}

		protected override MouseState GetMousePointerEventData(int id)
		{
			return null;
		}

		private PointerEventData.FramePressState GetStateForButton(int id)
		{
			return PointerEventData.FramePressState.Pressed;
		}
	}
}

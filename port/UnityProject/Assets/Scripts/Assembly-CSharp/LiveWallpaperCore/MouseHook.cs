namespace LiveWallpaperCore
{
	public sealed class MouseHook : HookBase
	{
		public delegate void OnMouseMessage(MouseData data, MouseMessages message);

		public OnMouseMessage onMouseMessage;

		public MouseHook(OnMouseMessage callback)
		{
		}

		private void MouseHookEvent(object sender, HookEventArgs e)
		{
		}

		protected override void OnHookEvent(HookEventArgs e)
		{
		}

		~MouseHook()
		{
		}
	}
}

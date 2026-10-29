namespace LiveWallpaperCore
{
	public sealed class KeyboardHook : HookBase
	{
		public delegate void OnKeyboardMessage(KeyboardData data, KeyboardMessages message);

		public OnKeyboardMessage onKeyboardMessage;

		public KeyboardHook(OnKeyboardMessage callback)
		{
		}

		private void KeyboardHookEvent(object sender, HookEventArgs e)
		{
		}

		protected override void OnHookEvent(HookEventArgs e)
		{
		}

		~KeyboardHook()
		{
		}
	}
}

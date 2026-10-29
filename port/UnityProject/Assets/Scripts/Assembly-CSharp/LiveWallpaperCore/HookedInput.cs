using System.Collections.Generic;
using UnityEngine;

namespace LiveWallpaperCore
{
	public static class HookedInput
	{
		private static MouseHook mouseHook;

		private static KeyboardHook keyboardHook;

		private static readonly Dictionary<int, MouseMessages> mouseInputs;

		private static readonly Dictionary<HookKeyCode, KeyboardMessages> keyboardInputs;

		public static Vector3 MousePosition => default;

		public static void Enable()
		{
		}

		public static void Disable()
		{
		}

		private static void OnMouseEvent(MouseData data, MouseMessages message)
		{
		}

		private static void OnKeyboardEvent(KeyboardData data, KeyboardMessages message)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void ClearInputs()
		{
		}

		public static bool GetKey(HookKeyCode key)
		{
			return false;
		}

		public static bool GetKeyDown(HookKeyCode key)
		{
			return false;
		}

		public static bool GetKeyUp(HookKeyCode key)
		{
			return false;
		}

		public static bool GetMouseButton(int button)
		{
			return false;
		}

		public static bool GetMouseButtonDown(int button)
		{
			return false;
		}

		public static bool GetMouseButtonUp(int button)
		{
			return false;
		}
	}
}

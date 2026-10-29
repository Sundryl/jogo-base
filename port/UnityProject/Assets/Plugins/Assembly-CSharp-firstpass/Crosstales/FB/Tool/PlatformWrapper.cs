using Crosstales.FB.Wrapper;
using UnityEngine;

namespace Crosstales.FB.Tool
{
	[HelpURL("https://www.crosstales.com/media/data/assets/FileBrowser/api/class_crosstales_1_1_f_b_1_1_tool_1_1_platform_wrapper.html")]
	public class PlatformWrapper : MonoBehaviour
	{
		[Header("Configuration Settings")]
		[Tooltip("Platform specific wrapper for the app (empty wrapper = default of the OS).")]
		public PlatformWrapperTuple[] Configuration;

		[Header("Default")]
		[Tooltip("Default wrapper of the app (empty = default of the OS).")]
		public BaseCustomFileBrowser DefaultWrapper;

		[Header("Parenting")]
		[Tooltip("Set the provider as child of the FileBrowser parent object (default: true).")]
		public bool SetAsChild;

		[Header("Editor")]
		[Tooltip("Use the default wrapper inside the Editor (default: false).")]
		public bool UseDefault;

		private void Start()
		{
		}
	}
}

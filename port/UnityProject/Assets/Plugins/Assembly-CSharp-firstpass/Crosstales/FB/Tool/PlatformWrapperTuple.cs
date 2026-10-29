using System;
using Crosstales.Common.Model.Enum;
using Crosstales.FB.Wrapper;

namespace Crosstales.FB.Tool
{
	[Serializable]
	public class PlatformWrapperTuple
	{
		public Platform Platform;

		public BaseCustomFileBrowser CustomWrapper;
	}
}

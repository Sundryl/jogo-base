namespace Crosstales.FB.Wrapper
{
	public abstract class BaseFileBrowserStandalone : BaseFileBrowser
	{
		public override bool canOpenFile => false;

		public override bool canOpenFolder => false;

		public override bool canSaveFile => false;

		public override bool canOpenMultipleFiles => false;
	}
}

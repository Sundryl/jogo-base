using System;

namespace Crosstales.FB.Wrapper
{
	public abstract class BaseFileBrowser : IFileBrowser
	{
		protected byte[] openSingleFileData;

		protected string lastOpenFile;

		public abstract bool canOpenFile { get; }

		public abstract bool canOpenFolder { get; }

		public abstract bool canSaveFile { get; }

		public abstract bool canOpenMultipleFiles { get; }

		public abstract bool canOpenMultipleFolders { get; }

		public abstract bool isPlatformSupported { get; }

		public abstract bool isWorkingInEditor { get; }

		public virtual string CurrentOpenSingleFile { get; set; }

		public virtual string[] CurrentOpenFiles { get; set; }

		public virtual string CurrentOpenSingleFolder { get; set; }

		public virtual string[] CurrentOpenFolders { get; set; }

		public virtual string CurrentSaveFile { get; set; }

		public virtual byte[] CurrentOpenSingleFileData => null;

		public virtual byte[] CurrentSaveFileData { get; set; }

		public string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		public abstract string[] OpenFiles(string title, string directory, string defaultName, bool multiselect, params ExtensionFilter[] extensions);

		public string OpenSingleFolder(string title, string directory)
		{
			return null;
		}

		public abstract string[] OpenFolders(string title, string directory, bool multiselect);

		public abstract string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions);

		public abstract void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect, ExtensionFilter[] extensions, Action<string[]> cb);

		public abstract void OpenFoldersAsync(string title, string directory, bool multiselect, Action<string[]> cb);

		public abstract void SaveFileAsync(string title, string directory, string defaultName, ExtensionFilter[] extensions, Action<string> cb);
	}
}

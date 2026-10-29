using System;
using System.Runtime.CompilerServices;
using Crosstales.Common.Util;
using Crosstales.FB.Wrapper;
using UnityEngine;
using UnityEngine.Serialization;

namespace Crosstales.FB
{
	[HelpURL("https://www.crosstales.com/media/data/assets/FileBrowser/api/class_crosstales_1_1_f_b_1_1_file_browser.html")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	public class FileBrowser : Singleton<FileBrowser>
	{
		public delegate void OpenFilesStart();

		public delegate void OpenFilesComplete(bool selected, string singleFile, string[] files);

		public delegate void OpenFoldersStart();

		public delegate void OpenFoldersComplete(bool selected, string singleFolder, string[] folders);

		public delegate void SaveFileStart();

		public delegate void SaveFileComplete(bool selected, string file);

		[SerializeField]
		[Tooltip("Custom wrapper for File Browser.")]
		[Header("Custom Wrapper")]
		private BaseCustomFileBrowser customWrapper;

		[Tooltip("Enable or disable the custom wrapper (default: false).")]
		[SerializeField]
		private bool customMode;

		[Header("Titles")]
		[Tooltip("Title for the 'Open File'-dialog.")]
		[SerializeField]
		private string titleOpenFile;

		[SerializeField]
		[Tooltip("Title for the 'Open Files'-dialog.")]
		private string titleOpenFiles;

		[SerializeField]
		[Tooltip("Title for the 'Open Folder'-dialog.")]
		private string titleOpenFolder;

		[SerializeField]
		[Tooltip("Title for the 'Open Folders'-dialog.")]
		private string titleOpenFolders;

		[SerializeField]
		[Tooltip("Title for the 'Save File'-dialog.")]
		private string titleSaveFile;

		[Header("Labels")]
		[Tooltip("Text for 'All Files'-filter (*)")]
		[SerializeField]
		private string textAllFiles;

		[Tooltip("Default name of the save-file.")]
		[SerializeField]
		private string nameSaveFile;

		[FormerlySerializedAs("LegacyFolderBrowser")]
		[Header("Windows Settings")]
		[Tooltip("Use the legacy folder browser under Windows (default: false).")]
		[SerializeField]
		private bool legacyFolderBrowser;

		[Tooltip("Ask to overwrite existing file in save dialog (default: true).")]
		[SerializeField]
		private bool askOverwriteFile;

		[Header("macOS Settings")]
		[Tooltip("Allow synchronous calls under macOS (default: false).")]
		[SerializeField]
		private bool allowSyncCalls;

		[Tooltip("Always read the file data under UWP (default: false).")]
		[SerializeField]
		[Header("UWP (WSA) Settings")]
		private bool alwaysReadFile;

		private static string lastOpenSingleFile;

		private static string[] lastOpenFiles;

		private static string lastOpenSingleFolder;

		private static string[] lastOpenFolders;

		private static string lastSaveFile;

		private WrapperHolder wrapperHolder;

		[Header("Events")]
		public OnOpenFilesCompleted OnOpenFilesCompleted;

		public OnOpenFoldersCompleted OnOpenFoldersCompleted;

		public OnSaveFileCompleted OnSaveFileCompleted;

		[CompilerGenerated]
		private OpenFilesStart m_OnOpenFilesStart;

		[CompilerGenerated]
		private OpenFilesComplete m_OnOpenFilesComplete;

		[CompilerGenerated]
		private OpenFoldersStart m_OnOpenFoldersStart;

		[CompilerGenerated]
		private OpenFoldersComplete m_OnOpenFoldersComplete;

		[CompilerGenerated]
		private SaveFileStart m_OnSaveFileStart;

		[CompilerGenerated]
		private SaveFileComplete m_OnSaveFileComplete;

		public BaseCustomFileBrowser CustomWrapper
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool CustomMode
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool LegacyFolderBrowser
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AskOverwriteFile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AllowSyncCalls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool AlwaysReadFile
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public string TitleOpenFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleOpenFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleOpenFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleOpenFolders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TitleSaveFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string TextAllFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string NameSaveFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentOpenSingleFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentOpenSingleFileName => null;

		public string[] CurrentOpenFiles
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentOpenSingleFolder
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentOpenSingleFolderName => null;

		public string[] CurrentOpenFolders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentSaveFile
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string CurrentSaveFileName => null;

		public byte[] CurrentOpenSingleFileData => null;

		public byte[] CurrentSaveFileData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool canOpenFile => false;

		public bool canOpenFolder => false;

		public bool canSaveFile => false;

		public bool canOpenMultipleFiles => false;

		public bool canOpenMultipleFolders => false;

		public bool isPlatformSupported => false;

		public bool isWorkingInEditor => false;

		public event OpenFilesStart OnOpenFilesStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OpenFilesComplete OnOpenFilesComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OpenFoldersStart OnOpenFoldersStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event OpenFoldersComplete OnOpenFoldersComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event SaveFileStart OnSaveFileStart
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public event SaveFileComplete OnSaveFileComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public string OpenSingleFile(string extension = "*")
		{
			return null;
		}

		public string OpenSingleFile(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		public string OpenSingleFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		public string[] OpenFiles(string extension = "*")
		{
			return null;
		}

		public string[] OpenFiles(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		public string[] OpenFiles(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		public string OpenSingleFolder()
		{
			return null;
		}

		public string OpenSingleFolder(string title, string directory = "")
		{
			return null;
		}

		public string[] OpenFolders()
		{
			return null;
		}

		public string[] OpenFolders(string title, string directory = "")
		{
			return null;
		}

		public string SaveFile(string defaultName = "", string extension = "*")
		{
			return null;
		}

		public string SaveFile(string title, string directory, string defaultName, params string[] extensions)
		{
			return null;
		}

		public string SaveFile(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
			return null;
		}

		public void OpenSingleFileAsync(string extension = "*")
		{
		}

		public void OpenSingleFileAsync(string title, string directory, string defaultName, params string[] extensions)
		{
		}

		public void OpenSingleFileAsync(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		public void OpenFilesAsync(bool multiselect = true, params string[] extensions)
		{
		}

		public void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect = true, params string[] extensions)
		{
		}

		public void OpenFilesAsync(string title, string directory, string defaultName, bool multiselect = true, params ExtensionFilter[] extensions)
		{
		}

		public void OpenSingleFolderAsync()
		{
		}

		public void OpenSingleFolderAsync(string title, string directory = "")
		{
		}

		public void OpenFoldersAsync(bool multiselect = true)
		{
		}

		public void OpenFoldersAsync(string title, string directory = "", bool multiselect = true)
		{
		}

		public void SaveFileAsync(string defaultName = "", string extension = "*")
		{
		}

		public void SaveFileAsync(string title, string directory, string defaultName, params string[] extensions)
		{
		}

		public void SaveFileAsync(string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		public string[] GetFiles(string path, bool isRecursive, params ExtensionFilter[] extensions)
		{
			return null;
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.GetFiles' instead.")]
		public string[] GetFiles(string path, bool isRecursive = false, params string[] extensions)
		{
			return null;
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.GetDirectories' instead.")]
		public string[] GetFolders(string path, bool isRecursive = false)
		{
			return null;
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.GetDrives' instead.")]
		public string[] GetDrives()
		{
			return null;
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.CopyFile' instead.")]
		public static void CopyFile(string sourceFile, string destFile, bool move = false)
		{
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.CopyDirectory' instead.")]
		public static void CopyFolder(string sourcePath, string destPath, bool move = false)
		{
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.ShowFile' instead.")]
		public static void ShowFile(string file)
		{
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.ShowPath' instead.")]
		public static void ShowFolder(string path)
		{
		}

		[Obsolete("Please use 'Crosstales.Common.Util.FileHelper.OpenFile' instead.")]
		public static void OpenFile(string file)
		{
		}

		public void OpenFilesAsync(Action<string[]> cb, bool multiselect = true, params string[] extensions)
		{
		}

		public void OpenFilesAsync(Action<string[]> cb, string title, string directory, string defaultName, bool multiselect = true, params string[] extensions)
		{
		}

		public void OpenFilesAsync(Action<string[]> cb, string title, string directory, string defaultName, bool multiselect = true, params ExtensionFilter[] extensions)
		{
		}

		public void OpenFoldersAsync(Action<string[]> cb, bool multiselect = true)
		{
		}

		public void OpenFoldersAsync(Action<string[]> cb, string title, string directory = "", bool multiselect = true)
		{
		}

		public void SaveFileAsync(Action<string> cb, string defaultName = "", string extension = "*")
		{
		}

		public void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params string[] extensions)
		{
		}

		public void SaveFileAsync(Action<string> cb, string title, string directory, string defaultName, params ExtensionFilter[] extensions)
		{
		}

		private string getNameFromPath(string path)
		{
			return null;
		}

		private void resetOpenFiles(params string[] paths)
		{
		}

		private void resetOpenFolders(params string[] paths)
		{
		}

		private void resetSaveFile(params string[] paths)
		{
		}

		private ExtensionFilter[] getFilter(params string[] extensions)
		{
			return null;
		}

		private void onOpenFilesStart()
		{
		}

		private void onOpenFilesComplete(bool selected, string singleFile, string[] files)
		{
		}

		private void onOpenFoldersStart()
		{
		}

		private void onOpenFoldersComplete(bool selected, string singleFolder, string[] folders)
		{
		}

		private void onSaveFileStart()
		{
		}

		private void onSaveFileComplete(bool selected, string file)
		{
		}
	}
}

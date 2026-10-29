using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Steamworks;
using UnityEngine;

public class WorkshopUploader
{
	[CompilerGenerated]
	private sealed class _003CUploadItem_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public string itemString;

		public string itemType;

		public string itemName;

		public string itemDescription;

		public string imagePath;

		public ulong itemID;

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
		public _003CUploadItem_003Ed__41(int _003C_003E1__state)
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

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		public SteamUGCQueryCompleted_t queryResult;

		public bool isIoFailure;

		public bool isCompleted;

		internal void _003CCheckAndUpdateWorkshopItem_003Eb__0(SteamUGCQueryCompleted_t result, bool failure)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CCheckAndUpdateWorkshopItem_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		public WorkshopItemContent itemContent;

		private uint _003Cpage_003E5__2;

		private bool _003CitemFound_003E5__3;

		private UGCQueryHandle_t _003Cquery_003E5__4;

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
		public _003CCheckAndUpdateWorkshopItem_003Ed__42(int _003C_003E1__state)
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

	private const long MaxFileSizeBytes = 10485760L;

	private const int c_WorkshopPreviewMaxSizeBytes = 1048575;

	private const int c_BetaNameBufferSize = 256;

	private const string c_WorkshopDefaultUntitledKey = "WorkshopUploadDefaultUntitled";

	private const string c_WorkshopDefaultTitleMapKey = "WorkshopUploadDefaultTitleMap";

	private const string c_WorkshopDefaultTitleCultureKey = "WorkshopUploadDefaultTitleCulture";

	private const string c_WorkshopDefaultTitleReligionKey = "WorkshopUploadDefaultTitleReligion";

	private const string c_WorkshopDefaultTitleMilitaryKey = "WorkshopUploadDefaultTitleMilitary";

	private const string c_WorkshopDefaultDescriptionMapKey = "WorkshopUploadDefaultDescriptionMap";

	private const string c_WorkshopDefaultDescriptionCultureKey = "WorkshopUploadDefaultDescriptionCulture";

	private const string c_WorkshopDefaultDescriptionReligionKey = "WorkshopUploadDefaultDescriptionReligion";

	private const string c_WorkshopDefaultDescriptionMilitaryKey = "WorkshopUploadDefaultDescriptionMilitary";

	private static WorkshopItemContent currentItemContent;

	private static bool s_IsUploadInProgress;

	private static readonly int[] s_WorkshopPreviewMaxDimensions;

	private static readonly int[] s_WorkshopPreviewJpgQualities;

	public static bool IsUploadInProgress => false;

	public static bool IsUploadBlockedForCurrentBranch()
	{
		return false;
	}

	public static bool TryShowUploadBlockedWarning()
	{
		return false;
	}

	public static string GetCurrentUploadBlockedMessage()
	{
		return null;
	}

	private static string T(string key, string overrideLanguage = null)
	{
		return null;
	}

	private static string TF(string key, string overrideLanguage, params object[] args)
	{
		return null;
	}

	private static string GetDefaultTitleKey(string itemType)
	{
		return null;
	}

	private static string GetDefaultDescriptionKey(string itemType)
	{
		return null;
	}

	private static string BuildDefaultItemTitleInternal(string itemType, string itemName, string overrideLanguage)
	{
		return null;
	}

	private static string GetDefaultItemDescriptionInternal(string itemType, string overrideLanguage)
	{
		return null;
	}

	private static void SetUploadInProgress(bool isUploadInProgress)
	{
	}

	private static bool IsActiveUpload(WorkshopItemContent itemContent)
	{
		return false;
	}

	private static bool ShouldIgnoreUploadCallback(WorkshopItemContent itemContent, string stage)
	{
		return false;
	}

	private static void CancelCurrentUpload()
	{
	}

	private static void ShowUploadProgress()
	{
	}

	private static void ShowUploadSuccess(WorkshopItemContent itemContent)
	{
	}

	private static void ShowUploadFailure(string message)
	{
	}

	private static void ShowUploadDialog(string message, List<WarningWithAction.ButtonConfig> buttons, bool useCloseButton)
	{
	}

	private static void CloseWorkshopUploadPanel()
	{
	}

	private static void OpenWorkshopItemPage(ulong workshopId)
	{
	}

	public static string BuildDefaultItemTitle(string itemType, string itemName)
	{
		return null;
	}

	public static string GetDefaultItemDescription(string itemType)
	{
		return null;
	}

	public static bool IsDefaultItemTitle(string itemType, string itemName, string candidate)
	{
		return false;
	}

	public static bool IsDefaultItemDescription(string itemType, string candidate)
	{
		return false;
	}

	[IteratorStateMachine(typeof(_003CUploadItem_003Ed__41))]
	public static IEnumerator UploadItem(string itemString, string itemType, string itemName, string itemDescription, string imagePath, ulong itemID)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCheckAndUpdateWorkshopItem_003Ed__42))]
	private static IEnumerator CheckAndUpdateWorkshopItem(WorkshopItemContent itemContent)
	{
		return null;
	}

	private static void CreateNewWorkshopItem(WorkshopItemContent itemContent)
	{
	}

	private static void OnCreateItem(WorkshopItemContent itemContent, CreateItemResult_t pCallback, bool bIOFailure)
	{
	}

	private static void UpdateExistingItem(WorkshopItemContent itemContent)
	{
	}

	private static void OnItemUpdateSubmitted(WorkshopItemContent itemContent, SubmitItemUpdateResult_t pCallback, bool bIOFailure)
	{
	}

	private static string PrepareWorkshopContent(string itemString, string itemType)
	{
		return null;
	}

	private static void CopyDirectory(string sourceDir, string destinationDir)
	{
	}

	private static Texture2D LoadTextureFromFile(string filePath)
	{
		return null;
	}

	private static bool TryPrepareWorkshopPreview(WorkshopItemContent itemContent, out string _previewPath, out long _previewSizeBytes)
	{
		_previewPath = null;
		_previewSizeBytes = default;
		return false;
	}

	private static bool IsSupportedWorkshopPreviewExtension(string extension)
	{
		return false;
	}

	private static byte[] EncodePreviewJpgUnderLimit(Texture2D sourceTexture, out int _finalWidth, out int _finalHeight, out int _finalQuality)
	{
		_finalWidth = default;
		_finalHeight = default;
		_finalQuality = default;
		return null;
	}

	private static Texture2D ResizeTexture(Texture2D sourceTexture, int targetWidth, int targetHeight)
	{
		return null;
	}

	public static void UploadSaveToWorkshop(string saveId)
	{
	}

	private static string PrepareWorkshopMapContent(string sourceFilePath, string fileName)
	{
		return null;
	}

	private static string BuildWorkshopMapContentFolderName(string fileName, string sourceFilePath)
	{
		return null;
	}

	private static Texture2D GeneratePreviewImage(SaveInfo saveInfo)
	{
		return null;
	}

	private static void SubmitItemToWorkshop(WorkshopItemContent itemContent)
	{
	}

	public static void UploadCultureSetToWorkshop(string cultureSet)
	{
	}

	private static string PrepareCultureSetContent(string cultureSet)
	{
		return null;
	}

	private static Texture2D GeneratePreviewImageForCultureSet(string cultureSet)
	{
		return null;
	}

	public static void UploadReligionSetToWorkshop(string religionSet)
	{
	}

	private static string PrepareReligionSetContent(string religionSet)
	{
		return null;
	}

	private static string ResolveModReligionSetFolder(string religionSet)
	{
		return null;
	}

	private static Texture2D GeneratePreviewImageForReligionSet(string religionSet)
	{
		return null;
	}

	private static string PrepareMilitaryPackageContent(string packageFolderName)
	{
		return null;
	}

	private static List<string> BuildItemTags(string itemType)
	{
		return null;
	}

	private static bool TryGetBlockedBetaBranchName(out string betaBranchName)
	{
		betaBranchName = null;
		return false;
	}

	private static string BuildUploadBlockedMessage(string betaBranchName)
	{
		return null;
	}
}

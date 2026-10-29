using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json.Linq;

public class SaveSystem
{
	private enum WarSystemLoadMode
	{
		V1 = 0,
		V2 = 1,
		LegacyMixed = 2
	}

	public enum SaveFileLoadMode
	{
		Automatic = 0,
		StreamingWithLegacyOptimization = 1,
		NonStreaming = 2
	}

	private sealed class LegacySaveOptimizationStats
	{
		public int RemovedHistoryEvents;

		public int CompactedCharacterTraits;

		public int CompactedCharacters;

		public long RemovedStateHistorySnapshots;

		public int CompactedStates;

		public long RemovedProvinceHistoryPoints;

		public int CompactedProvinces;

		public int FailedModules;

		public bool HasChanges => false;
	}

	private sealed class StreamedRootMetadata
	{
		public int EntryCount;

		public int HistoryTimePointCount;

		public bool ShouldOptimizeLegacyData;
	}

	private sealed class BinarySaveContainerHeader
	{
		public int ContainerVersion;

		public long RootUtf8ByteLength;

		public byte[] InitializationVector;
	}

	private sealed class CountingStream : Stream
	{
		private readonly Stream m_InnerStream;

		private readonly bool m_LeaveOpen;

		public long BytesRead { get; private set; }

		public long BytesWritten { get; private set; }

		public override bool CanRead => false;

		public override bool CanSeek => false;

		public override bool CanWrite => false;

		public override long Length => 0L;

		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public CountingStream(Stream _innerStream, bool _leaveOpen)
		{
		}

		public override void Flush()
		{
		}

		public override int Read(byte[] _buffer, int _offset, int _count)
		{
			return 0;
		}

		public override long Seek(long _offset, SeekOrigin _origin)
		{
			return 0L;
		}

		public override void SetLength(long _value)
		{
		}

		public override void Write(byte[] _buffer, int _offset, int _count)
		{
		}

		protected override void Dispose(bool _disposing)
		{
		}
	}

	private sealed class SerializedStateHistoryPoint
	{
		public long TimePoint;

		public JObject Snapshot;
	}

	[CompilerGenerated]
	private sealed class _003CBackupAllSavesCoroutine_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		private float _003CwaitTime_003E5__2;

		private float _003CmaxWaitTime_003E5__3;

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
		public _003CBackupAllSavesCoroutine_003Ed__35(int _003C_003E1__state)
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

	public const string SaveFileExtension = ".save";

	public const string c_AutoSaveFileName = "autosave";

	private const int c_MaxSaveNameLength = 80;

	private static List<SaveInfo> _saveInfos;

	private const string CurrentCellDataVersion = "1.0";

	private const string CurrentLogicDataVersion = "3.1";

	private const string CurrentSaveFormatVersion = "2";

	private const string LegacySaveFormatVersion = "1";

	private const string SaveFormatVersionKey = "SaveFormatVersion";

	private const string CurrentSaveDataOptimizationVersion = "1";

	private const string SaveDataOptimizationVersionKey = "SaveDataOptimizationVersion";

	private const string SaveContainerHeaderV2 = "NFW_SAVE_V2";

	private const string c_BinarySaveContainerMagic = "NFW_SAVE_BIN";

	private const int c_BinarySaveContainerVersion = 1;

	private const int c_BinarySaveIvSizeBytes = 16;

	private const string c_SaveEncryptionKey = "o7E@:5UwTW_>XV9_8I?~eoux7E7?Kn~t";

	public const long c_LargeSaveStreamingThresholdBytes = 31457280L;

	private const int c_SaveStreamBufferSize = 131072;

	private static readonly byte[] s_BinarySaveContainerMagicBytes;

	private static readonly bool s_ForceStreamingSaveLoadForTesting;

	private const string c_WarSystemVersionKey = "WarSystemVersion";

	private const string c_WarSystemVersionV1 = "V1";

	private const string c_WarSystemVersionV2 = "V2";

	private const string c_WarSystemVersionLegacyMixed = "LegacyMixed";

	public static string GetSaveDirectory()
	{
		return null;
	}

	public static string NormalizeSaveFilePath(string filePath)
	{
		return null;
	}

	private static bool LooksLikeSaveFilePath(string value)
	{
		return false;
	}

	public static string SanitizeSaveName(string saveName)
	{
		return null;
	}

	private static bool IsReservedWindowsFileName(string fileName)
	{
		return false;
	}

	private static bool IsPathInsideDirectory(string filePath, string directoryPath)
	{
		return false;
	}

	private static string BuildLocalSaveFilePath(string saveName)
	{
		return null;
	}

	private static string ResolveExistingSaveFilePath(string saveIdentifier, bool isFilename)
	{
		return null;
	}

	public static void BackupAllSaves()
	{
	}

	[IteratorStateMachine(typeof(_003CBackupAllSavesCoroutine_003Ed__35))]
	private static IEnumerator BackupAllSavesCoroutine()
	{
		return null;
	}

	private static string GetWorkshopSaveDirectoryForBackup()
	{
		return null;
	}

	public static string GetWorkshopSaveDirectory()
	{
		return null;
	}

	public static List<SaveInfo> GetAllSaves(bool isLoadWorkshop = true)
	{
		return null;
	}

	private static void AddSaveInfo(List<SaveInfo> saves, HashSet<string> seenSavePaths, string filePath, bool isWorkshopItem)
	{
	}

	public static SaveInfo FindSaveInfo(string saveIdentifier, bool isLoadWorkshop = true)
	{
		return null;
	}

	private static SaveInfo FindSaveInfoInList(List<SaveInfo> saves, string saveIdentifier)
	{
		return null;
	}

	private static string DecryptString(string cipherText)
	{
		return null;
	}

	private static string EncryptString(string plainText)
	{
		return null;
	}

	private static void WriteRootV2(TextWriter _writer, Dictionary<string, string> _saveData)
	{
	}

	private static Dictionary<string, string> DeserializeRootWithCompatibility(string rootPayload, string sourceLabel)
	{
		return null;
	}

	private static bool TryDeserializeRootV2(string rootPayload, out Dictionary<string, string> saveData)
	{
		saveData = null;
		return false;
	}

	private static Dictionary<string, string> DeserializeRootV2SinglePass(TextReader _reader)
	{
		return null;
	}

	private static bool ShouldOptimizeLegacySaveDataVersion(bool _hasVersion, string _optimizationVersion, string _sourceLabel)
	{
		return false;
	}

	private static void OptimizeLegacySaveDataBeforeDeserialize(Dictionary<string, string> _saveData, string _sourceLabel)
	{
	}

	private static void LogLegacySaveOptimizationStats(string _sourceLabel, LegacySaveOptimizationStats _stats)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void OptimizeLegacyModule(Dictionary<string, string> _saveData, string _moduleKey, Func<string, string> _optimizer, LegacySaveOptimizationStats _stats, string _sourceLabel)
	{
	}

	private static int GetHistoryTimePointCount(Dictionary<string, string> _saveData)
	{
		return 0;
	}

	private static int GetHistoryTimePointCountFromJson(string _timeManagerJson)
	{
		return 0;
	}

	private static string OptimizeLegacyHistoryDataJson(string _json, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static string OptimizeLegacyCharacterDataJson(string _json, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static bool CompactLegacyCharacterTraits(JObject _character, out int _compactedTraitCount)
	{
		_compactedTraitCount = default;
		return false;
	}

	private static string OptimizeLegacyProvinceDataJson(string _json, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static string OptimizeLegacyProvinceJson(string _serializedProvince, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static string OptimizeLegacyStateDataJson(string _json, int _historyTimePointCount, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static string OptimizeLegacyStateJson(string _serializedState, int _historyTimePointCount, LegacySaveOptimizationStats _stats)
	{
		return null;
	}

	private static bool StateHistorySnapshotsHaveSameContent(JObject _left, JObject _right)
	{
		return false;
	}

	private static bool IsDeadStateHistorySnapshot(JObject _snapshot)
	{
		return false;
	}

	private static JObject CreateDeathStateHistorySnapshot(JObject _source)
	{
		return null;
	}

	private static string RewriteEmbeddedJsonStringArray(string _json, string _arrayPropertyName, Func<string, string> _itemOptimizer)
	{
		return null;
	}

	private static bool IsBinarySaveContainer(string _filePath)
	{
		return false;
	}

	public static bool IsBinarySaveContainerFile(string _filePath)
	{
		return false;
	}

	private static BinarySaveContainerHeader ReadBinarySaveContainerHeader(Stream _stream)
	{
		return null;
	}

	private static void WriteBinarySaveContainer(string _filePath, Dictionary<string, string> _saveData)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, string> LoadBinarySaveDataSinglePass(string _filePath)
	{
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static Dictionary<string, string> LoadLargeSaveDataStreaming(string _filePath)
	{
		return null;
	}

	private static void StreamDecryptAndDecompressSaveToFile(string _saveFilePath, string _temporaryRootPath)
	{
	}

	private static bool TryReadStreamedRootV2Metadata(string _temporaryRootPath, out StreamedRootMetadata _metadata)
	{
		_metadata = null;
		return false;
	}

	private static Dictionary<string, string> DeserializeStreamedRootV2(string _temporaryRootPath, StreamedRootMetadata _metadata, string _sourceLabel)
	{
		return null;
	}

	private static string OptimizeLegacyStreamedModuleValue(string _moduleKey, string _originalJson, int _historyTimePointCount, LegacySaveOptimizationStats _stats, string _sourceLabel)
	{
		return null;
	}

	private static Dictionary<string, string> DeserializeLegacyRootJsonFromFile(string _temporaryRootPath)
	{
		return null;
	}

	private static StreamReader CreateTemporaryRootReader(string _temporaryRootPath)
	{
		return null;
	}

	private static bool TryReadLine(TextReader _reader, out string _line)
	{
		_line = null;
		return false;
	}

	private static bool TryReadIntLine(TextReader _reader, out int _value)
	{
		_value = default;
		return false;
	}

	private static bool TryReadLengthPrefixedBlock(TextReader _reader, out string _value)
	{
		_value = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string ReadExactString(TextReader _reader, int _length)
	{
		return null;
	}

	private static bool SkipExactCharacters(TextReader _reader, int _length, char[] _buffer)
	{
		return false;
	}

	private static bool TryConsumeLengthPrefixedBlockTerminator(TextReader _reader)
	{
		return false;
	}

	private static bool ContainsNonWhitespace(TextReader _reader)
	{
		return false;
	}

	private static bool TryReadLine(string text, ref int index, out string line)
	{
		line = null;
		return false;
	}

	private static bool TryReadIntLine(string text, ref int index, out int value)
	{
		value = default;
		return false;
	}

	private static bool TryReadLengthPrefixedBlock(string text, ref int index, out string value)
	{
		value = null;
		return false;
	}

	private static string ResolveWarSystemVersionForSave()
	{
		return null;
	}

	public static void SaveGame(string saveId = null)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void SaveGameCore(string _saveId)
	{
	}

	private static void ReleaseTransientSaveMemory()
	{
	}

	private static void LogSaveMemory(string _stage)
	{
	}

	public static Dictionary<string, string> LoadGameData(string id, bool isFilename = false, bool loadFromResources = false, SaveFileLoadMode loadMode = SaveFileLoadMode.Automatic)
	{
		return null;
	}

	private static string CompressString(string text)
	{
		return null;
	}

	private static string DecompressString(string compressedText)
	{
		return null;
	}

	private static void WriteSaveFileAtomically(string filePath, Action<string> _writeTemporaryFile)
	{
	}

	public static void LoadGame(string saveId, bool isFilename = false, bool loadFromResources = false, bool showLoadWarnings = true, SaveFileLoadMode loadMode = SaveFileLoadMode.Automatic)
	{
	}

	private static WarSystemLoadMode ApplyWarSystemVersionAfterLoad(string savedVersion)
	{
		return WarSystemLoadMode.V1;
	}

	private static void NormalizeStateWarMarkersAfterLoad(WarSystemLoadMode loadMode)
	{
	}

	public static void DeleteSave(string id)
	{
	}

	private static string GetMapCultureWarningAfterLoad()
	{
		return null;
	}
}

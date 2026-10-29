using Puerts;

public class CustomLoader : ILoader
{
	private static readonly string EditorJsPath;

	public bool FileExists(string filepath)
	{
		return false;
	}

	public string ReadFile(string filepath, out string debugpath)
	{
		debugpath = null;
		return null;
	}

	private string GetResourcePath(string filepath)
	{
		return null;
	}

	private static string DecryptString(string cipherText)
	{
		return null;
	}
}

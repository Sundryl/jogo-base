using Puerts;

public class CombinedLoader : ILoader
{
	private DefaultLoader defaultLoader;

	private CustomLoader customLoader;

	public bool FileExists(string filepath)
	{
		return false;
	}

	public string ReadFile(string filepath, out string debugpath)
	{
		debugpath = null;
		return null;
	}
}

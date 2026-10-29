using System.Runtime.CompilerServices;
using UnityEngine.Networking;

public static class UnityWebRequestExtension
{
	public static TaskAwaiter<UnityWebRequest> GetAwaiter(this UnityWebRequestAsyncOperation operation)
	{
		return default;
	}
}

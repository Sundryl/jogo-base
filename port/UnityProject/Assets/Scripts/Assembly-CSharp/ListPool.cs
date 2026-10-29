using System.Collections.Generic;

internal static class ListPool<T>
{
	private static readonly Stack<List<T>> s_Stack;

	public static List<T> Get()
	{
		return null;
	}

	public static void Release(List<T> toRelease)
	{
	}
}

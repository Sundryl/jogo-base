using System;

public readonly struct PauseStateScope : IDisposable
{
	private readonly World m_World;

	private readonly bool m_PreviousPauseState;

	public PauseStateScope(World world)
	{
		m_World = null;
		m_PreviousPauseState = false;
	}

	public void Dispose()
	{
	}
}

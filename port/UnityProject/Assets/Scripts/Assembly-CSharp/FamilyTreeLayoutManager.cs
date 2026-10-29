using System.Collections.Generic;
using FantasyWorld.CharacterSystem;
using Newtonsoft.Json.Linq;
using Puerts;
using UnityEngine;

public class FamilyTreeLayoutManager
{
	private float m_NodeWidth;

	private float m_NodeHeight;

	private float m_HorizontalSpacing;

	private float m_VerticalSpacing;

	private bool m_IsHorizontalLayout;

	private int m_MaxGenerations;

	private JsEnv m_JsEnv;

	private bool m_JsLibLoaded;

	private JObject m_LayoutData;

	private Dictionary<int, Vector2> m_NodePositions;

	private string m_RawJavaScriptResponse;

	public void SetNodeSize(float width, float height)
	{
	}

	public void SetSpacing(float horizontal, float vertical)
	{
	}

	public void SetLayoutDirection(bool isHorizontal)
	{
	}

	public void SetMaxGenerations(int maxGenerations)
	{
	}

	public int GetMaxGenerations()
	{
		return 0;
	}

	private void InitializeJsEnvironment()
	{
	}

	public void CalculateLayout(Character rootCharacter, Family family, bool isHorizontal)
	{
	}

	private string ConvertCharactersToJsFormat(List<Character> characters)
	{
		return null;
	}

	private string CreateJsOptions(string rootId)
	{
		return null;
	}

	private List<Character> ExtractFamilyCharacters(Family family, int rootId)
	{
		return null;
	}

	private void ConvertLayoutToUnityPositions()
	{
	}

	private void RotateLayout()
	{
	}

	private void CenterTree()
	{
	}

	private void FallbackToSimpleLayout(Character rootCharacter, Family family, IReadOnlyList<Character> customCharacters = null)
	{
	}

	public Dictionary<int, Vector2> GetLayoutData()
	{
		return null;
	}

	public string GetRawJavaScriptData()
	{
		return null;
	}

	public Vector2 GetNodePosition(int characterId)
	{
		return default;
	}

	public List<(Vector2, Vector2, RelType)> GetConnectors()
	{
		return null;
	}

	public void Dispose()
	{
	}
}

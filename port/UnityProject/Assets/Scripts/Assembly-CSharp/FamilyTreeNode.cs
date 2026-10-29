using FantasyWorld.CharacterSystem;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class FamilyTreeNode : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
	private Character m_Character;

	private SinglePanel m_SinglePanel;

	private FamilyTreeUI m_TreeUI;

	private Button m_Button;

	private Color m_BaseColor;

	public Character Character => null;

	public RectTransform RectTransform { get; private set; }

	private void Awake()
	{
	}

	public void Initialize(Character character, FamilyTreeUI treeUI, Color nodeColor)
	{
	}

	private void UpdateDisplay()
	{
	}

	private string BuildDisplayText()
	{
		return null;
	}

	private string GetIdentityText()
	{
		return null;
	}

	public void OnPointerClick(PointerEventData eventData)
	{
	}

	private void OnEnable()
	{
	}

	public void RefreshDisplay()
	{
	}

	public void SetHighlight(bool isHighlighted, Color highlightColor)
	{
	}
}

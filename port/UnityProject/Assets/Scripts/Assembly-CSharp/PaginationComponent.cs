using System;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PaginationComponent : MonoBehaviour
{
	[Header("Pagination Settings")]
	[SerializeField]
	private int m_TotalItems;

	[SerializeField]
	private int m_ItemsPerPage;

	[SerializeField]
	private int m_CurrentPage;

	[Header("UI References")]
	[SerializeField]
	private Button m_PrevButton;

	[SerializeField]
	private Button m_NextButton;

	[SerializeField]
	private TextMeshProUGUI m_PageInfoText;

	[SerializeField]
	private TMP_InputField m_PageJumpInput;

	[SerializeField]
	private Button m_JumpButton;

	public GameObject contentContainer;

	[CompilerGenerated]
	private Action<int, int, int> m_OnPageChanged;

	private int m_TotalPages;

	public event Action<int, int, int> OnPageChanged
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

	private void Start()
	{
	}

	public void Initialize(int totalItems, int itemsPerPage = 5, int startPage = 1)
	{
	}

	private void InitializePagination()
	{
	}

	private int CalculateTotalPages()
	{
		return 0;
	}

	private void UpdateUI()
	{
	}

	private void UpdateButtonStates()
	{
	}

	private void UpdatePageInfoText()
	{
	}

	private void OnJumpButtonClicked()
	{
	}

	public void GoToPage(int pageNumber)
	{
	}

	public void GoToNextPage()
	{
	}

	public void GoToPreviousPage()
	{
	}

	private void NotifyPageChanged()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetItemsPerPage(int itemsPerPage)
	{
	}

	public int GetCurrentPage()
	{
		return 0;
	}

	public int GetTotalPages()
	{
		return 0;
	}

	public int GetStartIndex()
	{
		return 0;
	}

	public int GetEndIndex()
	{
		return 0;
	}

	public int GetItemsPerPage()
	{
		return 0;
	}
}

using System.Collections.Generic;

public class DouyinGameManager
{
	private static DouyinGameManager _instance;

	private Dictionary<string, PlayerData> _playerDataDict;

	public Dictionary<string, string> _playerAvatarUrlDict;

	public Dictionary<string, int> _playerGiftValueDict;

	private Dictionary<string, AllianceRequest> _pendingAllianceRequests;

	private const double ALLIANCE_REQUEST_TIMEOUT = 120.0;

	private Dictionary<string, float> _lastArmy1TimeDict;

	private const float ARMY_1_COOLDOWN = 3f;

	private Dictionary<string, float> _lastArmy666TimeDict;

	private HashSet<string> playerNoCurruptionSet;

	private const float ARMY_666_COOLDOWN = 3f;

	private Dictionary<string, PeaceRequest> _pendingPeaceRequests;

	private const double PEACE_REQUEST_TIMEOUT = 120.0;

	private Dictionary<string, float> _lastEndWarTimeDict;

	private const float END_WAR_COOLDOWN = 60f;

	private Dictionary<string, float> _lastEndAllWarTimeDict;

	private const float END_ALL_WAR_COOLDOWN = 120f;

	public static DouyinGameManager Instance => null;

	public void Start()
	{
	}

	public bool TryGetStateOwner(State state, out PlayerData playerData)
	{
		playerData = null;
		return false;
	}

	public void Clear()
	{
	}

	public void Update()
	{
	}

	private int GetStateId(State InState)
	{
		return 0;
	}

	private int GetStateId(string InStateName)
	{
		return 0;
	}

	private State GetValidState(int InStateId)
	{
		return null;
	}

	public bool JoinState(string playerId, string playerName, int stateId)
	{
		return false;
	}

	public bool RandomJoin(string playerId, string playerName)
	{
		return false;
	}

	public bool DeclareWar(string playerId, string targetStateName)
	{
		return false;
	}

	public bool DeclareWar(string playerId, string playerName, int targetStateId)
	{
		return false;
	}

	public bool TryRequestAlliance(string playerId, int targetStateId)
	{
		return false;
	}

	public bool AgreeAlliance(string playerId)
	{
		return false;
	}

	public bool ExitAlliance(string playerId)
	{
		return false;
	}

	private void CleanExpiredRequests()
	{
	}

	public void HandleGift(string playerId, long giftValue)
	{
	}

	public void Add10Army(GiftData giftData)
	{
	}

	public void Add1Army(string playerId)
	{
	}

	public void Add1Army666(string playerId)
	{
	}

	public void Add30Army(GiftData giftData)
	{
	}

	public void Add10EliteArmy(GiftData giftData)
	{
	}

	public void Add30EliteArmy(GiftData giftData)
	{
	}

	public void NoCurruption(GiftData giftData)
	{
	}

	public void EnableAllTraits(GiftData giftData)
	{
	}

	private int CalculateArmyCount(long giftValue)
	{
		return 0;
	}

	public bool CastAbility(string playerId, AbilityType type)
	{
		return false;
	}

	public PlayerData GetPlayerData(string playerId)
	{
		return null;
	}

	public void TryDeclareWarToAll(string secOpenId)
	{
	}

	internal bool LeaveAlliance(string secOpenId)
	{
		return false;
	}

	public bool TryRequestPeace(string playerId, int targetStateId)
	{
		return false;
	}

	public bool AgreePeace(string playerId)
	{
		return false;
	}

	public bool EndWar(string playerId, int targetStateId)
	{
		return false;
	}

	private void CleanExpiredPeaceRequests()
	{
	}

	internal void OnStateDestroyed(State state, State destroyByState)
	{
	}

	public bool EndAllWar(string playerId)
	{
		return false;
	}

	public void DestroyArmy66Percent(string playerId, bool istest = false)
	{
	}

	public void SetPoliticalSystem(string playerId, PoliticalSystem politicalSystem, string Type)
	{
	}

	public void SetEthnicAttribute(string playerId, EthnicAttribute ethnicAttribute, string Type)
	{
	}

	public void Add50EliteArmyAndRebel(GiftData giftData)
	{
	}

	public void ReducedCorruption(GiftData giftData)
	{
	}

	public void EnableRandom2Traits(string playerId)
	{
	}

	public void EnableRandom3Traits(GiftData giftData)
	{
	}
}

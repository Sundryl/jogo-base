using System;
using Newtonsoft.Json;

[Serializable]
public class RoundRankData
{
	[JsonProperty("id")]
	public int Id { get; set; }

	[JsonProperty("openId")]
	public string OpenId { get; set; }

	[JsonProperty("score")]
	public long Score { get; set; }

	[JsonProperty("worldScore")]
	public long WorldScore { get; set; }

	[JsonProperty("winningStreakCount")]
	public int WinningStreakCount { get; set; }

	[JsonProperty("winningPoints")]
	public int WinningPoints { get; set; }

	[JsonProperty("roomId")]
	public string RoomId { get; set; }

	[JsonProperty("roundId")]
	public long RoundId { get; set; }

	[JsonProperty("nickname")]
	public string Nickname { get; set; }

	[JsonProperty("avatarUrl")]
	public string AvatarUrl { get; set; }

	[JsonProperty("worldRank")]
	public int WorldRank { get; set; }

	[JsonProperty("createTime")]
	public string CreateTime { get; set; }
}

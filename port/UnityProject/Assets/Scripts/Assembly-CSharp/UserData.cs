using System;
using Newtonsoft.Json;

[Serializable]
public class UserData
{
	[JsonProperty("score")]
	public long Score { get; set; }

	[JsonProperty("rankVersion")]
	public string RankVersion { get; set; }

	[JsonProperty("winningStreakCount")]
	public int WinningStreakCount { get; set; }

	[JsonProperty("avatarUrl")]
	public string AvatarUrl { get; set; }

	[JsonProperty("nickname")]
	public string Nickname { get; set; }

	[JsonProperty("rank")]
	public int Rank { get; set; }

	[JsonProperty("winningPoints")]
	public int WinningPoints { get; set; }

	[JsonProperty("worldScore")]
	public long WorldScore { get; internal set; }
}

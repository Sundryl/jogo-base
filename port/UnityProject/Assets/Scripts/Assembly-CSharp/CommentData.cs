using System;
using Newtonsoft.Json;

[Serializable]
public class CommentData
{
	[JsonProperty("msg_id")]
	public string MessageId { get; set; }

	[JsonProperty("sec_openid")]
	public string SecOpenId { get; set; }

	[JsonProperty("content")]
	public string Content { get; set; }

	[JsonProperty("avatar_url")]
	public string AvatarUrl { get; set; }

	[JsonProperty("nickname")]
	public string Nickname { get; set; }

	[JsonProperty("timestamp")]
	public long Timestamp { get; set; }
}

using System;
using Newtonsoft.Json;

[Serializable]
public class DyCloudSocketMessage
{
	[JsonProperty("msg_id")]
	public string MsgId { get; set; }

	[JsonProperty("msg_type")]
	public string MsgType { get; set; }

	[JsonProperty("data")]
	public string Data { get; set; }
}

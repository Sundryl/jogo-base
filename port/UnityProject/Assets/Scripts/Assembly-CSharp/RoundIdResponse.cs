using System;
using Newtonsoft.Json;

[Serializable]
public class RoundIdResponse
{
	[JsonProperty("roundId")]
	public long roundId { get; set; }
}

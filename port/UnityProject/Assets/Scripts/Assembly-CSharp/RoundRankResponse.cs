using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class RoundRankResponse
{
	[JsonProperty("msg")]
	public string Message { get; set; }

	[JsonProperty("data")]
	public List<RoundRankData> Data { get; set; }

	[JsonProperty("err_no")]
	public int ErrorCode { get; set; }
}

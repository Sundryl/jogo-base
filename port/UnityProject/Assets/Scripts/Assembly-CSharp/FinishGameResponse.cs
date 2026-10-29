using System;
using System.Collections.Generic;
using Newtonsoft.Json;

[Serializable]
public class FinishGameResponse
{
	[JsonProperty("msg")]
	public string Message { get; set; }

	[JsonProperty("data")]
	public List<FinishGameData> Data { get; set; }

	[JsonProperty("err_no")]
	public int ErrorNo { get; set; }
}

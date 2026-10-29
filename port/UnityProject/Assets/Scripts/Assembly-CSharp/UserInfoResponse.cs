using System;
using Newtonsoft.Json;

[Serializable]
public class UserInfoResponse
{
	[JsonProperty("msg")]
	public string Message { get; set; }

	[JsonProperty("data")]
	public UserData Data { get; set; }

	[JsonProperty("err_no")]
	public int ErrorCode { get; set; }
}

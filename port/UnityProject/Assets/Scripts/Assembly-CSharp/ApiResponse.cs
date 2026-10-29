using System;
using Newtonsoft.Json;

[Serializable]
public class ApiResponse
{
	public int errcode;

	public string errmsg;
}
[Serializable]
public class ApiResponse<T>
{
	[JsonProperty("err_no")]
	public int ErrorNo { get; set; }

	[JsonProperty("err_msg")]
	public string ErrorMsg { get; set; }

	[JsonProperty("data")]
	public string Data { get; set; }
}

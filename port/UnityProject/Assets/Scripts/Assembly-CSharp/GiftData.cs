using System;

[Serializable]
public class GiftData
{
	public string msg_id { get; set; }

	public string sec_openid { get; set; }

	public string sec_gift_id { get; set; }

	public int gift_num { get; set; }

	public int gift_value { get; set; }

	public string avatar_url { get; set; }

	public string nickname { get; set; }

	public long timestamp { get; set; }

	public string UserId => null;

	public string UserName => null;

	public int GiftValue => 0;
}

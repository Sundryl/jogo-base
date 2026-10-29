using System.Collections.Generic;

public class FinishGameRequest
{
	public string appId { get; set; }

	public string anchorOpenId { get; set; }

	public string roomId { get; set; }

	public long roundId { get; set; }

	public long startTime { get; set; }

	public List<UserRoundData> userResults { get; set; }

	public List<GroupResult> groupResults { get; set; }
}

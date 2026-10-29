using System.Threading.Tasks;
using UnityEngine;

public class WaitForTask : CustomYieldInstruction
{
	private Task task;

	public override bool keepWaiting => false;

	public WaitForTask(Task task)
	{
	}
}

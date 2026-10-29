using UnityEngine;

public abstract class Ability<T> : MonoBehaviour
{
	public float cooldown;

	protected float currentCooldown;

	protected virtual string GetAbilityName()
	{
		return null;
	}

	protected virtual void Update()
	{
	}

	protected bool CanCast()
	{
		return false;
	}

	protected void StartCooldown()
	{
	}

	public abstract bool Cast(T target);
}

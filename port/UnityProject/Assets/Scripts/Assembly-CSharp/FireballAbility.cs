using UnityEngine;

public class FireballAbility : ProvinceTargetAbility
{
	public float damage;

	public float fireballHeight;

	protected override string GetAbilityName()
	{
		return null;
	}

	public override bool Cast(Province targetProvince)
	{
		return false;
	}

	public void OnFireballImpact(Vector3 impactPosition, Province targetProvince)
	{
	}
}

using UnityEngine;

public abstract class ProvinceTargetAbility : Ability<Province>
{
	protected GameObject effectPrefab;

	protected State casterState;

	protected ITargetSelectionStrategy targetSelector;

	public virtual void Initialize(State owner, ITargetSelectionStrategy selector)
	{
	}

	public void SetPrefab(GameObject prefab)
	{
	}

	public Province SelectTarget()
	{
		return null;
	}

	public bool AutoCast()
	{
		return false;
	}
}

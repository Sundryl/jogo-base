using UnityEngine;

public class FireballBehaviour : MonoBehaviour
{
	public float animationSpeed;

	private FireballAbility ability;

	private Province targetProvince;

	private Animator animator;

	private const string METEOR_ANIM = "FireballMetero";

	private const string BURST_ANIM = "FireballBurst";

	private AnimationClip meteorClip;

	private AnimationClip burstClip;

	private void Start()
	{
	}

	public void Initialize(Vector3 target, FireballAbility parentAbility, Province province)
	{
	}

	private void OnImpact()
	{
	}
}

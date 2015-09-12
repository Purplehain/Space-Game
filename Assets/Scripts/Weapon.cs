using UnityEngine;
using System.Collections;

public class Weapon
{

	public float damage;
	public float cooldown;
	public float energyUsage;

	public enum weaponType{
		Laser,
		Rocket,
		Projectile
	}

	public enum weaponSize{
		small,
		medium,
		large
	}
}


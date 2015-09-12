using UnityEngine;
using System.Collections;

public class Item
{
	public string name;
	public string desc;
	public int itemID;
	public Sprite itemIcon;
	public float minValue;
	public float maxValue;
	public float weight;
	public float durability;
	public float itemDamage;
	public float itemShield;
	public float itemEnergy;

	public ItemType itemType;

	public enum ItemType{
		Weapon,
		Chassis,
		Module,
		Ressources

	}


	public Item(string Name, string Desc, float MinValue, float MaxValue, float Weight)
	{
		name = Name;
		desc = Desc;
		minValue = MinValue;
		maxValue = MaxValue;
		weight = Weight;
	}
}

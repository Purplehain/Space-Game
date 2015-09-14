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

	public ItemType itemType;

	public enum ItemType{
        Consumeable,

	}


	public Item(string Name,int ID, string Desc, float MinValue, float MaxValue, float Weight)
	{
		name = Name;
		desc = Desc;
        itemID = ID;
		minValue = MinValue;
		maxValue = MaxValue;
		weight = Weight;
        itemIcon = Resources.Load<Sprite>("ItemIcons/" + Name);
	}
}

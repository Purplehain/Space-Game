using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

public class CityGenerator : EditorWindow {

	public GameObject buildingShape = null;
	public List<GameObject> buildings = new List<GameObject>();

	public float maxHeight = 10;
	public float minHeight = 1;
	public float chance = 15;
	public Vector3 citySize = new Vector3(20,20,20);

	[MenuItem("City/Generator")]
	static void Init()
	{
		CityGenerator window = (CityGenerator)EditorWindow.GetWindow(typeof(CityGenerator));
	}

	private void OnGUI()
	{
		buildingShape = EditorGUILayout.ObjectField(buildingShape, typeof(GameObject)) as GameObject;

		EditorGUILayout.Space();
	}
}

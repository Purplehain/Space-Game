using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {


	public int xOrg;
	public int yOrg;
	private int xRes;
	private int yRes;
	public float scale = 1.0f;


	public Terrain terrain;
	public float[,] heights;

	// Use this for initialization
	void Start () {
		xRes = terrain.terrainData.heightmapWidth;
		yRes = terrain.terrainData.heightmapHeight;
		heights = terrain.terrainData.GetHeights(0, 0, xRes, yRes);

		PerlinNoise();
	}
	private float lastHeight;
	public void PerlinNoise()
	{
		lastHeight = 0;

		for(int x = 0; x < xRes; x++)
		{
			for(int y = 0; y < yRes; y++)
			{
				float xVal = xOrg + x / xRes * scale;
				float yVal = yOrg + y / yRes * scale;
				float rnd = Mathf.PerlinNoise(x, y);
				Debug.Log(rnd);
				float height = heights[x,y];
				if(rnd <= 0.3f && height != 0){
					height += lastHeight-height-1;
				}
				if(rnd >= 0.7f && height != 600)
				{
					height += lastHeight-height+1;
				}
				else height = lastHeight;
			


				lastHeight = height;
				heights[x,y] = height;
			}
			Debug.Log(heights[x,2]);
		}

		terrain.terrainData.SetHeights(0,0,heights);
	}

}

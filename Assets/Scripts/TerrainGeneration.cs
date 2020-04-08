using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGeneration : MonoBehaviour
{
	private TerrainData myTerrainData;
	public Vector3 worldSize;
	public int resolution = 129;            // number of vertices along X and Z axes
	float[,] heightArray;


	void Start()
	{
		myTerrainData = gameObject.GetComponent<TerrainCollider>().terrainData;
		worldSize = new Vector3(1000, 35, 1000);
		myTerrainData.size = worldSize;
		myTerrainData.heightmapResolution = resolution;
		heightArray = new float[resolution, resolution];

		// Fill the height array with values!
		// Uncomment the Ramp and Flat methods to test them out!
		//Flat(1.0f);
		//Ramp();
		Perlin();

		// Assign values from heightArray into the terrain object's heightmap
		myTerrainData.SetHeights(0, 0, heightArray);
	}


	void Update()
	{

	}

	/// <summary>
	/// Flat()
	/// Assigns heightArray identical values
	/// </summary>
	void Flat(float value)
	{
		// Fill heightArray with 1's
		for (int i = 0; i < resolution; i++)
		{
			for (int j = 0; j < resolution; j++)
			{
				heightArray[i, j] = value;
			}
		}
	}


	/// <summary>
	/// Ramp()
	/// Assigns heightsArray values that form a linear ramp
	/// </summary>
	void Ramp()
	{
		// Fill heightArray with linear values
		for (int i = 0; i < resolution; i++)
		{
			for (int j = 0; j < resolution; j++)
			{
				heightArray[i, j] = 1 - (j * 0.005f);
			}
		}

	}

	/// <summary>
	/// Perlin()
	/// Assigns heightsArray values using Perlin noise
	/// </summary>
	void Perlin()
	{
		// Fill heightArray with Perlin-based values
		float xCoord = 0;
		float yCoord = 1;
		for (int i = 0; i < resolution; i++)
		{
			xCoord = 0;
			yCoord += 0.05f;
			for (int j = 0; j < resolution; j++)
			{
				float sample = Mathf.PerlinNoise(xCoord, yCoord);
				xCoord += 0.05f;
				heightArray[i, j] = sample;
			}
		}

	}
}

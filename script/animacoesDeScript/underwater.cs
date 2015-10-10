﻿using UnityEngine;
using System.Collections;

public class underwater : MonoBehaviour {
	
	//This script enables underwater effects. Attach to main camera.
	
	//Define variable
	public int underwaterLevel = 45;
	
	//The scene's default fog settings
	private bool defaultFog = RenderSettings.fog;
	private Color defaultFogColor = RenderSettings.fogColor;
	private float defaultFogDensity = RenderSettings.fogDensity;
	private Material defaultSkybox = RenderSettings.skybox;
	private Material noSkybox = null;
	
	void Start () {
		//Set the background color
		camera.backgroundColor = new Color(0, 0.4f, 0.7f, 1);
		defaultSkybox= RenderSettings.skybox;
	}
	
	void Update () {
		if (transform.position.y < underwaterLevel)
		{
			RenderSettings.fog = true;
			RenderSettings.fogColor = new Color(0, 0.4f, 0.7f, 0.6f);
			RenderSettings.fogDensity = 0.04f;
			RenderSettings.skybox = noSkybox;
		}
		else
		{
			RenderSettings.fog = defaultFog;
			RenderSettings.fogColor = defaultFogColor;
			RenderSettings.fogDensity = defaultFogDensity;
			RenderSettings.skybox = defaultSkybox;
		}
	}
}

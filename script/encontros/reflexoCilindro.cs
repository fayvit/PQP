﻿using UnityEngine;
using System.Collections;

public class reflexoCilindro : MonoBehaviour {
	public Vector4[] cor = {new Vector4 (75, 172, 204, 255),new Vector4 (255, 75, 204, 255),Vector4.zero};
	public bool natural = true;

	public Transform gambiarraPraConcertarAGambiarra;
	// Use this for initialization
	void Start () {
		cor [0] /= 255;
		cor [1] /= 255;
		cor [0].w = 0.45f;
		cor [1].w = 0.45f;
		cor [2] = cor [0];
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 V = gambiarraPraConcertarAGambiarra.localPosition;
		gambiarraPraConcertarAGambiarra.localPosition = new Vector3(V.x,-5.85f,V.z);

		MeshRenderer[] X = GetComponentsInChildren<MeshRenderer> ();
		if((cor[2]-cor[0]).magnitude>0.05f && natural == true)
		{
			cor[2] = Vector4.Lerp(cor[2],cor[0],Time.deltaTime);
		}else if((cor[2] - cor[0]).magnitude<0.05f)
			natural = false;

		if (natural == false && (cor [2] - cor [1]).magnitude>0.05f)
						cor [2] = Vector4.Lerp (cor [2], cor [1], Time.deltaTime);
				else if ((cor [2] - cor [1]).magnitude<0.05f)
						natural = true;
		//int tempo = (int)(Time.time*20f);
		//print (tempo);
		//if(tempo%15==1)

		foreach(MeshRenderer i in X)
		{
			i.renderer.material.color = new Color(cor[2].x, cor[2].y,cor[2].z,cor[2].w);
		}
	
	}
}

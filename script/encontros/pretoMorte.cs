using UnityEngine;
using System.Collections;

public class pretoMorte : MonoBehaviour {

	float lerp = 0;
	public bool entrando = true;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		if(entrando)
			lerp = Mathf.Lerp(lerp,1,Time.deltaTime);
		else
			lerp = Mathf.Lerp(lerp,0,0.5f*Time.deltaTime);
		GUIStyle verm = new GUIStyle (GUI.skin.box);
		Texture2D vermelha = new Texture2D (10, 10);
		for(int i=0;i<20;i++)
			for(int j=0;j<20;j++)
				vermelha.SetPixel (i,j,new Color(0,0,0,lerp));
		vermelha.Apply ();
		verm.normal.background = vermelha;
		GUI.Box(new Rect(0,0,Screen.width,Screen.height),"",verm);

		if(!entrando && lerp<0.01f)
			Destroy(this);
	}
}

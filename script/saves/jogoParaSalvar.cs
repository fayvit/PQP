using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class jogoParaSalvar {
	public static jogoParaSalvar corrente;

	public List<item> osItens;
	public List<Criature> ativos;
	public List<Criature> armagedados;
	public uint cristais;
	public List<float> posicao = new List<float>();
	public Rotacao rotacao = new Rotacao();
	public string nomeCena;
	public string nomeSave;
	public float tempoDeJogo = 0;
	public Dictionary<string,bool> shift = new Dictionary<string,bool>();
	public Dictionary<string,int> contadorChave = new Dictionary<string, int>();

	public jogoParaSalvar()
	{

	}
	
}

[System.Serializable]
public struct Rotacao
{
	float x,y,z;

	public Rotacao(Vector3 V = default(Quaternion))
	{
		x = V.x;
		y = V.y;
		z = V.z;
	}

	public Vector3 forward
	{
		get{return new Vector3(x,y,z);}
	}
}

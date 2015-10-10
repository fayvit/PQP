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
	public string nomeCena;
	public string nomeSave;
	public float tempoDeJogo = 0;
	public Dictionary<string,bool> shift = new Dictionary<string,bool>();
	public Dictionary<string,int> contadorChave = new Dictionary<string, int>();

	public jogoParaSalvar()
	{

	}
	
}

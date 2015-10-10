using UnityEngine;
using System.Collections;

public class elementosDoJogo : LuvaDeGuarde {

	public GameObject[] doJogo;
	public Material[] materiais;
	public GameObject[] colisores;
	public GameObject[] criatures;
	public Texture2D[] miniGolpes;
	public Texture2D[] miniCriatures;
	public Texture2D[] miniItens;
	public Texture2D[] miniStatus;
	public static elementosDoJogo el;

	public GUISkin skin;
	public GUISkin destaque;

	void Start()
	{
		el = this;
	}

	public GameObject retorna(string ele,string oq = "doJogo")
	{

		GameObject retorno = null;

		switch(oq)
		{
		case "doJogo":
			for(int i=0;i<doJogo.Length;i++)
			{
				if(doJogo[i].name == ele)
					retorno = doJogo[i];
			}
		break;
		case "criature":
		case "Criature":
			retorno = criature(ele);
		break;
		case "colisor":
			retorno = retornaColisor(ele);
		break;
		}


		return retorno;
	}

	public Texture2D retornaMini(string ele,string oQ)
	{

		Texture2D retorno = null;
		Texture2D[] conjunto = null;

		switch(oQ)
		{
		case "golpe":
			conjunto = miniGolpes;
		break;
		case "criature":
			conjunto = miniCriatures;
		break;
		case "itens":
			conjunto = miniItens;
		break;
		case "status":
			conjunto = miniStatus;
		break;
		}

		for(int i=0;i<conjunto.Length;i++)
		{
			if(conjunto[i].name == ele)
				retorno = conjunto[i];
		}
		
		return retorno;
	}

	public GameObject criature(string ele)
	{
		
		GameObject retorno = null;
		for(int i=0;i<criatures.Length;i++)
		{
			if(criatures[i].name == ele)
				retorno = criatures[i];
		}
		
		return retorno;
	}

	public GameObject retornaColisor(string ele)
	{
		
		GameObject retorno = null;
		for(int i=0;i<colisores.Length;i++)
		{
			if(colisores[i].name == ele)
				retorno = colisores[i];
		}
		
		return retorno;
	}
}	
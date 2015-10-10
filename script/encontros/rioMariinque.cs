using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rioMariinque: encontros {
	
	private readonly List<List<encontravel>> secaoEncontravel = new List<List<encontravel>>()
	{new List<encontravel>()// indice zero
		{

			new encontravel(nomesCriatures.Arpia,  1.1f,  5,8,1),
			new encontravel(nomesCriatures.Onarac,     1.4f,  5,8,1),
			new encontravel(nomesCriatures.Iruin,      1.0f,  5,8,1),
			new encontravel(nomesCriatures.Escorpion,  1.5f,  5,8,1),
			new encontravel(nomesCriatures.Escorpirey, 1.25f, 5,8,1),
			new encontravel(nomesCriatures.Fajin,      1.0f,  5,8,1),
			new encontravel(nomesCriatures.Abutre,     0.5f,  5,8,1),
			new encontravel(nomesCriatures.Marak,      0.5f,  5,8,1),
			new encontravel(nomesCriatures.Babaucu,   1.5f,  5,8,1),
			new encontravel(nomesCriatures.Aladegg,       0.25f, 5,8,1),




		}
	};
	
	protected override List<encontravel> listaEncontravel()
	{
		return secaoEncontravel[IndiceDoLocal()];
	}
	
	
	int IndiceDoLocal()
	{
		return 0;
	}


	protected override bool lugarSeguro(){
		/*
		bool seguro;
		if(
			(posHeroi.x>401.6
		 &&
		 posHeroi.x<666.82
		 &&
		 posHeroi.z>158.55
		 &&
		 posHeroi.z<310.54)
			||
			(posHeroi.x>1500
		 &&
		 posHeroi.x<1765.3
		 &&
		 posHeroi.z>184.1
		 &&
		 posHeroi.z<337)
			)
			seguro = true;
		else
			seguro = false;
		return seguro;
		*/
		return false;
	}
}

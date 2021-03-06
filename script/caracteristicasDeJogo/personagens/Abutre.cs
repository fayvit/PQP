﻿using System;
using UnityEngine;

[System.Serializable]
public class Abutre:Criature {

	public readonly nivelGolpe[] listaGolpes = {

		/* Golpes aprendiveis apenas com pergaminhos */
		
		new nivelGolpe(-1,nomesGolpes.sabreDeAsa,0,1),
		
		/*********************************************/

		new nivelGolpe(1,nomesGolpes.bico,0,1),
		new nivelGolpe(1,nomesGolpes.ventania,0,1),
		new nivelGolpe(2,nomesGolpes.ventosCortantes,0,1),
		new nivelGolpe(8,nomesGolpes.sobreVoo,0,1),
	};


	public Abutre(uint nivel = 1)
	{
		voador caracC = new voador ();

		Nome = "Abutre";

		meusTipos = new String[1];
		meusTipos [0] = nomeTipos.Voador.ToString();

		for(int cnt = 0; cnt < contraTipos.Length; cnt++)
		{
			contraTipos[cnt] = new tipos();
			contraTipos[cnt].Nome = ((nomeTipos)cnt).ToString();
			contraTipos[cnt].Mod = caracC._caracTipo[cnt].Mod;
		}

		emissor = "Esqueleto/corpo1/corpo2/corpo3/pescoco/cabeca";

		distanciaEmissora[nomesGolpes.ventosCortantes] = 0.75f;

		colisores[nomesGolpes.bico] = new colisor("Esqueleto/corpo1/corpo2/corpo3/pescoco/cabeca",
		                                  new Vector3(0,0,0),
		                                  new Vector3(-0.621f,-0,0.244f));
		colisores[nomesGolpes.sobreVoo] = new colisor("Esqueleto/corpo1/Bone_L",
		                                              new Vector3(0,0,0),
		                                              new Vector3(-0.81f,0.12f,-0.35f));

		/*		*****************
		 * 
			personalizaçao das taxas de evoluçao individual do Criature
			a soma deve ser 1 

			*********************
		 *
		 */
		
		
		cAtributos[(int)nomesAtributos.PV].Taxa = 0.18f;	//Pontos de Vida
		cAtributos[(int)nomesAtributos.PE].Taxa = 0.24f;	//pontos de Energia
		cAtributos[(int)nomesAtributos.Poder].Taxa = 0.23f;	//pontos de Poder
		cAtributos[(int)nomesAtributos.Forca].Taxa = 0.17f;	//pontos de Força
		cAtributos[(int)nomesAtributos.Defesa].Taxa = 0.18f;	//pontos de Defesa
		
		
		/***************************************************************************/


		apiceDoPulo = 2.6f;
		velocidadeNoAr = 2.2f;
		velocidadeCaindo = 5f;

		velocidadeAndando = 6.2f;

		velocidadeDeRotacaoParado = 1.51f;
		velocidadeDeRotacao = 2f;

		Golpes = golpesAtivos (nivel,listaGolpes);  incrementaNivel(nivel);

		listaDeGolpes = listaGolpes;
	}
}

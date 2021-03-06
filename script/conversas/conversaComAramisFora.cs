﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class conversaComAramisFora : MonoBehaviour {

	public int indiceDoEvento;

	public string indiceDaLuta = "lutouComAramis";
	public string indiceDaConversa = "falouComAramis";
	public string chaveDepoisDaDerrota = "AramisDepoisDeDerrotado";


	private conversaEmJogo cJ;
	private Menu menu;

	// Use this for initialization
	void Start () {
		cJ = GetComponent<conversaEmJogo>();

		if(variaveisChave.shift[indiceDaLuta])
			cJ.indiceDaConversa = chaveDepoisDaDerrota;
	}
	
	// Update is called once per frame
	void Update () {
		if(cJ.mensagemAtual == indiceDoEvento && !variaveisChave.shift[indiceDaLuta])
		{
			variaveisChave.shift[indiceDaConversa] = true;
			if(cJ.evento == false)
			{
				cJ.evento = true;
				menu = Camera.main.gameObject.AddComponent<Menu>();
				menu.setaDetalhes("somOuNaoAramis",
				                  bancoDeTextos.falacoes[heroi.lingua]["simOuNao"].ToArray(),
				                  0.7f,0.4f,0.25f,0.2f);
			}

			bool acao = Input.GetButtonDown("acao");

			if(Input.GetButtonDown("acaoAlt"))
			   if(menu.dentroOuFora()>-1)
			   	acao = true;

			if(acao)
			{
				switch(menu.escolha)
				{
				case 0:

					iniciandoContraTreinador();
					finalisaEsseEvento();
				break;
				case 1:
					finalisaEsseEvento();

				break;
				}
			}

		}else if(!cJ.evento  && variaveisChave.shift[indiceDaLuta])
		{
			cJ.atualizaIndiceDeConversa(chaveDepoisDaDerrota);
		}
	}

	protected virtual void iniciandoContraTreinador()
	{
		iniciaLutaContraAramis(gameObject,transform);
	}

	public static void iniciaLutaContraAramis(GameObject G,Transform T)
	{
		encontroDeTreinador edT = G.AddComponent<lutaContraAramis>();
		edT.encontraveis = new List<encontravelTreinador>()
		{
			new encontravelTreinador(nomesCriatures.Oderc,10,1),
			new encontravelTreinador(nomesCriatures.Flam,10,1),
			new encontravelTreinador(nomesCriatures.Urkan,10,1),
			new encontravelTreinador(nomesCriatures.Escorpion,10,1)
		};
		edT.tTreinador = T;
		edT.nomeDoTreinador = "Atos Aramis";
	}

	void finalisaEsseEvento()
	{
		menu.fechaJanela();
		cJ.evento = false;
		cJ.finalisaConversa();
		cJ.mensagemAtual = 0;
	}
}

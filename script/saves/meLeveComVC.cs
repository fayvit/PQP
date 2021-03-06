﻿using UnityEngine;
using System.Collections;

public class meLeveComVC : MonoBehaviour {
	bool naoPrintou = true;
	public bool carregar = false;


	private jogoParaSalvar j;
	// Use this for initialization
	void Start () {

		DontDestroyOnLoad(this);

		print("Esse script executou Start agora");
	}

	static void zeraUltimoUso(heroi H)
	{
		for(int i=0;i<H.criaturesAtivos.Count;i++)
		{
			for(int j=0;j<H.criaturesAtivos[i].Golpes.Length;j++)
			{
				H.criaturesAtivos[i].Golpes[j].UltimoUso = 0;
			}
		}

		for(int i=0;i<H.criaturesArmagedados.Count;i++)
		{
			for(int j=0;j<H.criaturesArmagedados[i].Golpes.Length;j++)
			{
				H.criaturesArmagedados[i].Golpes[j].UltimoUso = 0;
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
	if(naoPrintou && Application.loadedLevelName != "saveAndLoad")
		{
			j = jogoParaSalvar.corrente;
			if(carregar){
	

				Transform T = GameObject.FindWithTag("Player").transform;
				Vector3 auxInstance = new Vector3(j.posicao[0],j.posicao[1],j.posicao[2]);
				RaycastHit hit;
				movimentoBasico mB = T.GetComponent<movimentoBasico>();
				if(Physics.Raycast (auxInstance,Vector3.down,out hit))
				{
					auxInstance = hit.point+(mB.Y.distanciaFundamentadora+0.25f)*Vector3.up;

				}
				
				T.position = auxInstance;
				T.rotation = Quaternion.LookRotation(j.rotacao.forward);


				heroi H = T.GetComponent<heroi>();

				H.itens = jogoParaSalvar.corrente.osItens;
				H.criaturesAtivos = jogoParaSalvar.corrente.ativos;
				H.criaturesArmagedados = jogoParaSalvar.corrente.armagedados ;
				H.cristais = jogoParaSalvar.corrente.cristais ;
				heroi.tempoNoJogo = jogoParaSalvar.corrente.tempoDeJogo;



				Destroy(GameObject.Find("CriatureAtivo"));
				zeraUltimoUso(H);
				mB.adicionaOCriature();

				pausaJogo.pause = false;
				variaveisChave.particularidadesDeCaregamento();

			
			}

			naoPrintou = false;
			Destroy(gameObject);

		}
	}





}

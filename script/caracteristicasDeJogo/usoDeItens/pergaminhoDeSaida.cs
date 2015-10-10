using UnityEngine;
using System.Collections;

public class pergaminhoDeSaida : MonoBehaviour {

	public saidaDeCaverna S;


	private Transform T;
	private float tempoDecorrido = 0;
	private faseDaSaida fase = faseDaSaida.instanciandoGeiserCriature;

	enum faseDaSaida
	{
		instanciandoGeiserCriature,

		instanciandoGeiserPersonagem,


	}

	// Use this for initialization
	void Start () {
		T = GameObject.Find("CriatureAtivo").transform;
		T.GetComponent<umCriature>().enabled = false;
		T.GetComponent<sigaOLider>().enabled = false;
		T.GetComponent<NavMeshAgent>().enabled = false;
		Destroy(
		Instantiate(
			elementosDoJogo.el.retorna("geiserDeEnergia"),
			T.position,
			elementosDoJogo.el.retorna("geiserDeEnergia").transform.rotation),2);
	}
	
	// Update is called once per frame
	void Update () {
		tempoDecorrido+=Time.deltaTime;

		switch(fase)
		{
		case faseDaSaida.instanciandoGeiserCriature:
			T.position+=0.4f*Time.deltaTime*Vector3.up;
			if(tempoDecorrido>2)
			{
				SkinnedMeshRenderer[] sKs =  T.GetComponentsInChildren<SkinnedMeshRenderer>();
				foreach(SkinnedMeshRenderer sk in sKs)
					sk.enabled = false;

				T = GameObject.FindWithTag("Player").transform;
				T.GetComponent<CharacterController>().enabled = false;
				Destroy(
					Instantiate(
					elementosDoJogo.el.retorna("geiserDeEnergia"),
					T.position,
					elementosDoJogo.el.retorna("geiserDeEnergia").transform.rotation),3);
				fase = faseDaSaida.instanciandoGeiserPersonagem;
				tempoDecorrido = 0;
			}
		break;
		case faseDaSaida.instanciandoGeiserPersonagem:
			T.position+=0.4f*Time.deltaTime*Vector3.up;
			if(tempoDecorrido>2)
			{
				SkinnedMeshRenderer[] sKs =  T.GetComponentsInChildren<SkinnedMeshRenderer>();
				foreach(SkinnedMeshRenderer sk in sKs)
					sk.enabled = false;

				if(tempoDecorrido>2)
				{
					GameObject G = new GameObject();
					
					mudeCena mudador = G.AddComponent<mudeCena>();
					DontDestroyOnLoad(G);
					mudador.nomeCena = S.cenaAlvo;
					mudador.posicao = S.posAlvo;
					mudador.olhePraLa = S.rotacaoAlvo;
					
					mudador.guardeValoresEMudeDeCena();
				}
				tempoDecorrido = 0;


			}
		break;
		}
	}
}

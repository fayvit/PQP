using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class conversaComAramis : conversaComMustaf {
	
	protected Dictionary<int,string> trocaTitulo = new Dictionary<int, string>()
	{
		{1,"\t\t\t <color=cyan>Cesar Corean</color>"},
		{2,""},
		{3,"\t\t\t <color=cyan>Cesar Corean</color>"},
		{5,"\t\t Atos Aramis"}
	};

	private Menu menu;

	private faseDaConversa estado = faseDaConversa.iniciando;

	protected enum faseDaConversa
	{
		iniciando,
		aproximandoDoMustaf,
		respostaDeConfornto
	}

	// Use this for initialization
	protected virtual void Start () {
		essaConversa = bancoDeTextos.falacoes[heroi.lingua][indiceDaConversa];
	}
	
	// Update is called once per frame
	void Update () {
		if(iniciou)
		{
			tempoDecorrido+=Time.deltaTime;

			switch(estado)
			{
			case faseDaConversa.iniciando:
				if(tempoDecorrido>2)
				{
					tCam.position = posCam1.position;
					tCam.rotation = posCam1.rotation;
					p.entrando = false;
					estado = faseDaConversa.aproximandoDoMustaf;
					tHeroi.LookAt(tConversador,Vector3.up);
					mens = tCam.gameObject.AddComponent<mensagemBasica>();
					mens.mensagem = essaConversa[0];

				}
			break;
			case faseDaConversa.aproximandoDoMustaf:
				CoreanAndaParaPerto();
				cameraLerp(posCam2);
				if(mensagemAtual+1<essaConversa.Count)
				{
					verificaTrocaMens();
					verificaTrocaTitulo(trocaTitulo);
				}else
				{
					verificaTrocaMens();
					estado = faseDaConversa.respostaDeConfornto;
					menu = tCam.gameObject.AddComponent<Menu>();
					menu.setaDetalhes("somOuNaoAramis",
					                  bancoDeTextos.falacoes[heroi.lingua]["simOuNao"].ToArray(),
					                  0.7f,0.4f,0.25f,0.2f);
				}
			break;
			case faseDaConversa.respostaDeConfornto:

				bool acao = Input.GetButtonDown("acao");
				if(Input.GetButtonDown("acaoAlt"))
					if(menu.dentroOuFora()>-1)
						acao = true;


				if(acao)
				{
					if(menu.escolha == 0)// isso e um sim
					{
						iniciaLutaComTreinador();
						encerraEste();

					}else
					{
						if(e)
							e.enabled = true;
						movimentoBasico.retornarFluxoHeroi();

						encerraEste();
					}
				}
				aHeroi.SetFloat("velocidade",0);

			break;
			}
		}
	
	}

	protected virtual void iniciaLutaComTreinador()
	{
		encontroDeTreinador edT = gameObject.AddComponent<lutaContraAramis>();
		edT.encontraveis = new List<encontravelTreinador>()
		{
			new encontravelTreinador(nomesCriatures.Oderc,10,1),
			new encontravelTreinador(nomesCriatures.Flam,10,1),
			new encontravelTreinador(nomesCriatures.Urkan,10,1),
			new encontravelTreinador(nomesCriatures.Escorpion,10,1)
		};
		edT.tTreinador = tConversador;
		edT.nomeDoTreinador = "Atos Aramis";
	}

	void encerraEste()
	{
		iniciou = false;
		estado = faseDaConversa.iniciando;
		mens.fechaJanela();
		menu.fechaJanela();
	}

	/*
	void OnTriggerEnter(Collider col)
	{

		if(variaveisChave.shift[variavelChave])
			Destroy(gameObject);
		else
		{
			if(!iniciou && col.tag == "Player")
			{
				preparaIniciaConversa();
				Collider esseCol = GetComponent<Collider>();
				esseCol.enabled = false;
				esseCol.isTrigger = false;
				iniciou = true;
				variaveisChave.shift[variavelChave] = true;
			}else if(!iniciou && col.tag == "Criature" && !heroi.emLuta)
			{
				alternancia a  = col.GetComponent<alternancia>();
				if(a)
					a.retornaAoHeroi();
			}
		}

	}*/
}

using UnityEngine;
using System.Collections;

public class abreCanoDeEsgoto : eventoComGolpe {

	public string chaveDoCano;
	public GameObject aSerDestruido;
	public Transform pos1Camera;

	private pretoMorte p;
	private bool iniciou = false;
	private float contadorDeTempo = 0;
	private faseDaAnima fase = faseDaAnima.iniciando;
	private Transform tCamera;

	private enum faseDaAnima
	{
		iniciando,
		colocaParticulas
	}

	// Use this for initialization
	void Start () {
		if(variaveisChave.shift[chaveDoCano])
		{
			if(aSerDestruido)
				Destroy(aSerDestruido);

			Destroy(this);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
		if(iniciou)
		{
			contadorDeTempo+=Time.deltaTime;

			switch(fase)
			{
			case faseDaAnima.iniciando:
				if(contadorDeTempo>1)
				{
					tCamera.position = pos1Camera.position;
					tCamera.rotation = pos1Camera.rotation;
					p.entrando = false;
					contadorDeTempo = 0;
					fase = faseDaAnima.colocaParticulas;
				}
			break;
			case faseDaAnima.colocaParticulas:
				if(contadorDeTempo>1)
				{

				}
			break;
			}
		}
	
	}

	public override void disparaEvento(nomesGolpes nomeDoGolpe)
	{
		if((nomeDoGolpe==nomesGolpes.sabreDeAsa
		   ||
		   nomeDoGolpe==nomesGolpes.sabreDeBastao
		   ||
		   nomeDoGolpe==nomesGolpes.sabreDeEspada
		   ||
		   nomeDoGolpe==nomesGolpes.sabreDeNadadeira
		   )
		   &&
		   !variaveisChave.shift[chaveDoCano]
		   )
		{
			movimentoBasico.pararFluxoHeroi();
			tCamera = Camera.main.transform;
			p = gameObject.AddComponent<pretoMorte>();
			iniciou = true;
		}
	}
}

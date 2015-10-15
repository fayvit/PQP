using UnityEngine;
using System.Collections;

public class transporteInterno : MonoBehaviour {

	public Vector3 posAlvo;
	public Color corDoFade = Color.black;

	private bool iniciou = false;
	private faseDoTransporte fase;
	private pretoMorte p;
	private float tempoDeCorrido = 0;
	private Transform T;

	private movimentoBasico mB;
	private encontros e;

	private enum faseDoTransporte
	{
		iniciando,
		retornando
	}
	// Use this for initialization
	void Start () {
		e = GameObject.Find("Terrain").GetComponent<encontros>();
	}

	protected virtual void iniciandoTransporte()
	{
		p.entrando = false;
		T.position = posAlvo;//(new melhoraPos()).novaPos(posAlvo);

		if(e)
		{
			e.zeraPosAnterior();
			e.enabled = true;
		}


		movimentoBasico.pararFluxoHeroi(true,false);
		fase = faseDoTransporte.retornando;
		tempoDeCorrido = 0;
		Destroy(GameObject.Find("CriatureAtivo"));
		T.GetComponent<movimentoBasico>().adicionaOCriature();
	}
	
	// Update is called once per frame
	void Update () {
		if(iniciou)
			{
			tempoDeCorrido+=Time.deltaTime;

			switch(fase)
			{
			case faseDoTransporte.iniciando:
				if(tempoDeCorrido>1.5f)
				{
					e.enabled = false;
					iniciandoTransporte();
				}
			break;
			case faseDoTransporte.retornando:
				if(tempoDeCorrido>1)
				{
					movimentoBasico.retornarFluxoHeroi();
					iniciou = false;
					fase = faseDoTransporte.iniciando;
					tempoDeCorrido = 0;
				}
			break;
			}
		}
	}

	void OnTriggerEnter(Collider col)
	{
		if(col.tag=="Player" && !heroi.emLuta  && !iniciou)
		{
			iniciou = true;
			if(e)
				e.enabled = false;
			movimentoBasico.pararFluxoHeroi(true,false,true,false);
			p = gameObject.AddComponent<pretoMorte>();
			p.cor = corDoFade;
			T = col.transform;
		}

		if(col.tag=="Criature" && !heroi.emLuta)
		{
			col.GetComponent<alternancia>().retornaAoHeroi();
		}
	}
}

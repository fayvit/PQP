using UnityEngine;
using System.Collections;

public abstract class Iprojetil: MonoBehaviour  {

	public float velocidadeProjetil = 6f;
	public GameObject dono;
	public string noImpacto;

	protected Quaternion Qparticles;

	protected void funcaoTrigger(Collider emQ)
	{

		if(emQ.gameObject != dono &&( emQ.tag != "cenario"|| velocidadeProjetil>0)&&emQ.tag!="desvieCamera"){
			facaImpacto(emQ.gameObject);
		}


	}

	protected void quaternionDeImpacto()
	{

		switch(noImpacto)
		{
			/*
		case "ImpactoDeFogo":
			Qparticles  =Quaternion.LookRotation(Vector3.up);
		break;
		*/
		case "impactoComum":
		case "impactoDeVento":
		case "impactoDeGosma":
		case "impactoDeGosmaAcida":
		case "impactoDeFogo":
			Qparticles = Quaternion.LookRotation(dono.transform.forward);
			break;
		default:
			Qparticles  = Quaternion.LookRotation(Vector3.up);
			break;
		}


	}

	protected void facaImpacto(GameObject emQ,bool colocaImpactos = false,bool destroiAqui = true,bool noTransform = false)
	{
		if(emQ.gameObject.tag == "eventoComGolpe")
		{
			emQ.GetComponent<eventoComGolpe>().disparaEvento(
				dono.GetComponent<acaoDeGolpe>().ativa.nomeID
				);
		}

		GameObject impacto = GameObject.Find("elementosDoJogo").GetComponent<elementosDoJogo>().retorna(noImpacto);
		GameObject impacto2 = null;

		if(!noTransform)
			impacto2 = (GameObject)Instantiate (impacto, transform.position,Qparticles);

		umCriature umC = emQ.transform.GetComponent<umCriature>();
		if(umC)
			if(umC.criature().cAtributos[0].Corrente>0)
				
			if(dono.GetComponent<acaoDeGolpe>()){
				acaoDeGolpe aG = dono.GetComponent<acaoDeGolpe>();						
				aG.tomaDanoUm(emQ.transform);

				if(noTransform)
					impacto2 = (GameObject)Instantiate (impacto, umC.transform.position,Qparticles);

				if(colocaImpactos)
					aG.impactos++;
			}
		
		if(impacto2)
			Destroy (impacto2, 1.5f);
		if(destroiAqui)
			Destroy (gameObject);
	}

}

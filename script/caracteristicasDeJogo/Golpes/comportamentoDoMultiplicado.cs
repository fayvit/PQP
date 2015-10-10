using UnityEngine;
using System.Collections;

public class comportamentoDoMultiplicado : Iprojetil {

	public Transform alvo;
	public Vector3 direcaoMovimento;
	public float tempoDestroy = 10;

	private CharacterController controle;
	private Animator animator;

	private float tempoAcumulado = 0;
	private Criature C;



	// Use this for initialization
	void Start () {
		controle = GetComponent<CharacterController>();
		animator = GetComponent<Animator>();
		C = dono.GetComponent<umCriature>().X;
		noImpacto = "impactoDeGosma";
	}
	
	// Update is called once per frame
	void Update () {

		tempoAcumulado += Time.deltaTime;



		if(!alvo)
			direcaoMovimento = transform.forward;
		else
		{
			if(Vector3.Distance(transform.position,alvo.position)>2.5f)
			{
				direcaoMovimento =   Vector3.Slerp(direcaoMovimento,alvo.position-transform.position,0.9f*Time.deltaTime);
				direcaoMovimento.Normalize();
			}else
				direcaoMovimento = (alvo.position-transform.position).normalized;
		}

		controle.Move(direcaoMovimento*velocidadeProjetil*Time.deltaTime);

		animator.SetFloat("velocidade",controle.velocity.magnitude);

		transform.rotation = Quaternion.Lerp(transform.rotation,
		                                     Quaternion.LookRotation(direcaoMovimento),
		                                     Time.deltaTime*5);
		if(C.cAtributos[0].Corrente<=0)
			meDestrua();

		if(tempoAcumulado> tempoDestroy)
		{
			meDestrua();
		}
	}

	void meDestrua()
	{
		Destroy(
			Instantiate(elementosDoJogo.el.retorna("impactoDeGosma"),transform.position+Vector3.up,
		            Quaternion.LookRotation(transform.forward)),
			2);
		
		Destroy(gameObject,2.1f);
		gameObject.SetActive(false);
	}

	void OnTriggerEnter (Collider hit)
	{

		if(!hit.gameObject.isStatic && hit.gameObject.layer != 8 && hit.gameObject!= dono)
		{
			print(hit.gameObject.name);
			Qparticles = Quaternion.LookRotation(transform.forward);
			funcaoTrigger(hit);
			meDestrua();
		}

	}

}

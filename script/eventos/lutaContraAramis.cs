using UnityEngine;
using System.Collections;

public class lutaContraAramis : encontroDeTreinador {

	private faseDaFinalisacao fase = faseDaFinalisacao.iniciando;
	private conversaEmJogo cJ;

	private enum faseDaFinalisacao
	{
		iniciando,
		primeirasMensagens
	}

	protected override void finalDeLuta()
	{
		switch(fase)
		{
		case faseDaFinalisacao.iniciando:

			tTreinador.position = posInicialTreinador;
			tHeroi.position = posHeroi;

			heroi.contraTreinador = false;
			//Invoke("olharEmLUtaAtrasado",0.5f);
			alternancia.olharEmLuta(tTreinador);
			cJ = tTreinador.GetComponent<conversaEmJogo>();
			variaveisChave.shift["lutouComAramis"]  = true;
			cJ.evento = true;
			cJ.atualizaIndiceDeConversa("AramisNoMOmentoDaDerrota");
			cJ.mensagemAtual = 0;
			if(!cJ.mens)
			{
				cJ.mens = tTreinador.gameObject.AddComponent<mensagemBasica>();
				cJ.mens.mensagem = bancoDeTextos.falacoes[heroi.lingua]["AramisNoMOmentoDaDerrota"][0];
			}

			cJ.verificaTrocaMens();
			fase = faseDaFinalisacao.primeirasMensagens;
			tHeroi.rotation = Quaternion.LookRotation(
				Vector3.ProjectOnPlane(-tHeroi.position+tTreinador.position,Vector3.up)
				);
			tTreinador.rotation = Quaternion.LookRotation(
				Vector3.ProjectOnPlane(tHeroi.position-tTreinador.position,Vector3.up)
				);
		break;
		case faseDaFinalisacao.primeirasMensagens:
			if(cJ.mensagemAtual <  cJ.numeroDeMensagens-1)
				cJ.verificaTrocaMens();
			else
			{
				e.enabled = true;
				cJ.finalisaConversa();
				cJ.evento = false;
				voltarParaPasseio();
				GameObject.FindWithTag("Player")
					.GetComponent<heroi>().itens.Add(new item(nomeIDitem.condecoracaoAlpha));
				Destroy(this);
			}
		break;
		}
	}

	void olharEmLUtaAtrasado()
	{
		alternancia.olharEmLuta(tTreinador);
	}

}

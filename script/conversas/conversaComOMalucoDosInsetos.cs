using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class conversaComOMalucoDosInsetos : conversaComAramis {

	protected override void Start()
	{
		trocaTitulo = new Dictionary<int, string>()
		{
			{1,"\t\t\t <color=cyan>Cesar Corean</color>"},
			{2,""},
			{3,"\t\t\t <color=cyan>Cesar Corean</color>"},
			{4,"\t\t Maluco dos Insetos"},
			{5,"\t\t\t <color=cyan>Cesar Corean</color>"},
			{6,"\t\t Maluco dos Insetos"}
		};
		base.Start();
	}

	protected override void iniciaLutaComTreinador()
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
		edT.nomeDoTreinador = "Maluco dos Insetos";
	}
}

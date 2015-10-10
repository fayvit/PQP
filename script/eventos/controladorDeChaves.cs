using UnityEngine;
using System.Collections;

public static class controladorDeChaves {

	public static void executa(string nomeCena)
	{
		switch(nomeCena)
		{
		case "planicieDeJadme":
			chavesDeJadme();
		break;
		}
	}

	static void chavesDeJadme()
	{
		if(variaveisChave.shift["comprouEstatuaDoAnubis"])
		{
			GameObject.Find("ShopDeJadme").GetComponent<shopBasico>().aVenda.RemoveAt(3);
		}
	}
}

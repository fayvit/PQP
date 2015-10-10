[System.Serializable]
public class tipos  {

	private float _mod;
	private string _nome;

	public tipos()
	{
		_mod = 1.0f;
		_nome = "";
	}

	public float Mod
	{
		get{return _mod;}
		set{_mod = value;}
	}

	public string Nome
	{
		get{return _nome;}
		set{_nome = value;}
	}
}

public enum nomeTipos
{
	Agua,
	Fogo,
	Planta,
	Gelo,
	Terra,
	Pedra,
	Psiquico,
	Eletrico,
	Normal,
	Veneno,
	Inseto,
	Voador,
	Gas
}

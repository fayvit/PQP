using UnityEngine;

[System.Serializable]

public class golpe: pontosBasicos{

	private string _tipo;
	private string _nome;

	private uint custoPE;
	private float tempoReuso;
	private float ultimoUso;
	private float _repulsaoDoDano;
	private float _tempoNoDano;
	private float distanciaDeEmissao;

	public caracGolpe CaracGolpe;
	public float taxaDeUso = 1;
	public float mod = 0;
	public nomesGolpes nomeID;

	public float tempoMoveMin = 0.25f;
	public float tempoMoveMax = 0.5f;
	public float tempoDestroy = 1;

	public golpe()
	{
		_tipo = "";
		_nome = "";
		Basico = 1;
		Corrente = 1;
		Maximo = 3;
		custoPE = 0;
		tempoReuso = 1f;
		ultimoUso = 0f;
		_repulsaoDoDano = 3f;
		_tempoNoDano = 0.25f;
		distanciaDeEmissao = 0;
		nomeID = nomesGolpes.nulo;
	}

	public float DistanciaDeEmissao
	{
		get{return distanciaDeEmissao;}
		set{distanciaDeEmissao = value;}
	}

	public float RepulsaoDoDano
	{
		get{return _repulsaoDoDano;}
		set{_repulsaoDoDano = value;}
	}

	public float TempoNoDano
	{
		get{return _tempoNoDano;}
		set{_tempoNoDano = value;}
	}

	public string Nome
	{
		get{return _nome;}
		set{_nome = value;}
	}

	public string Tipo
	{
		get{return _tipo;}
		set{_tipo = value;}
	}

	public float TempoReuso
	{
		get{return tempoReuso;}
		set{tempoReuso = value;}
	}

	public float UltimoUso
	{
		get{return	ultimoUso;}
		set{ultimoUso = value;}
	}

	public uint CustoPE
	{
		get{return custoPE;}
		set{custoPE = value;}
	}

}

public enum caracGolpe
{
	projetil,
	colisao,
	colisaoComPow,
	area,
	suporte,
	projetilPerseguidor,
	especialComParalisia,
	hitNoChao

}



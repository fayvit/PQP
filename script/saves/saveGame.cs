///*
using UnityEngine;
using UnityEngine.Serialization;
//using UnityEditor;
using System.Collections;

using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
//*/
/*
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using System.Collections;
using SevenZipRadical;
using Serialization;
using System.Reflection;
using System.Text;
using SevenZipRadical.Compression.LZMA;
using System.IO;
using System.Net;
*/

public static class saveGame {
	public static List<jogoParaSalvar> savedGames = new List<jogoParaSalvar>();

	public static void Save(int onde) {
		if(onde<0)
			savedGames.Add(jogoParaSalvar.corrente);
		else
			savedGames[onde] = jogoParaSalvar.corrente;
			
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Create (Application.persistentDataPath + "/criatures.ori");
		//SerializedObject sO = new SerializedObject((Object)GameObject.FindWithTag ("Player"));
		bf.Serialize(file, saveGame.savedGames);
	
		file.Close();
		/*
		try 
		{
			bf.Serialize(file, saveGame.savedGames);
		}
		catch (SerializationException e) 
		{
			Debug.Log("Failed to serialize. Reason: " + e.Message);
			throw;
		}
		finally 
		{
			file.Close();
		}
		*/

	}

	public static List<string> jogosSalvos()
	{
		List<string> retorno = new List<string>();
		saveGame.Load();
		if(saveGame.savedGames.Count>0)
		{
//			int i = 0;
			foreach(jogoParaSalvar j in saveGame.savedGames )
			{
				retorno.Add(j.nomeSave);
			}
		}

		return retorno;
	}


	public static void Load() {

		try
		{
			if(File.Exists(Application.persistentDataPath + "/criatures.ori")) {
				BinaryFormatter bf = new BinaryFormatter();
				FileStream file = File.Open(Application.persistentDataPath + "/criatures.ori", FileMode.Open);
				saveGame.savedGames = (List<jogoParaSalvar>)bf.Deserialize(file);
				file.Close();	
			}
		}catch(IOException e)
		{
			Debug.Log(e);
			mensagemEmLuta mL;

			if(GameObject.Find("Canvas"))
			{
				mL = GameObject.Find("Canvas").GetComponent<mensagemEmLuta>();
				if(mL)
					mL.fechador();
				mL =  GameObject.Find("Canvas").AddComponent<mensagemEmLuta>();
			}else
			{
				mL = Camera.main.gameObject.GetComponent<mensagemEmLuta>();
				if(mL)
					mL.fechador();
				mL =  Camera.main.gameObject.AddComponent<mensagemEmLuta>();
			}
			mL.positivo = true;
			mL.posX = 0.67f;
			mL.posY = 0.43f;
			mL.mensagem = "Foram encontrados arquivos de Save Corrompidos";
		}
	}
}



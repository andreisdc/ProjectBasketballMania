using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SaveData
{
	public int bestScore;
	public int money;
	public List<bool> listOfSkins;
	public bool isPremium;
	public SaveData(Player player)
	{
		bestScore = player._bestScore;
		money = player.GetMoney();
		listOfSkins = new List<bool>(player.listOfSkins);
		isPremium = player.isPremium;
	}
}

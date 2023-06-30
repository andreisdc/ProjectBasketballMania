using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
public class Player : MonoBehaviour
{
	public static Player instacne;
	public bool isPremium = false;
	public SpriteRenderer skin;
	public Vector3 spawnPoint;
	public Quaternion spawnRotation;
	public int _bestScore = 0;
	private int _money = 0;
	public List<bool> listOfSkins = new List<bool>() {
		true, false, false, false, false, false, false, false, false, false, false, false, false, false, false,
		false, false, false, false, false, false, false, false, false, false, false, false
	};

private void Awake()
	{
		

		if(instacne == null)
		{
			instacne = this;
			
			DontDestroyOnLoad(gameObject);
		}else
		{
			Destroy(gameObject);	
		}
		
	}

	public void LoadPlayer()
	{
		SaveData data = SaveSystem.LoadPlayer();
		_money = data.money;
		isPremium = data.isPremium;
		_bestScore = data.bestScore;
		listOfSkins = new List<bool>(data.listOfSkins);
	}

	private void Update()
	{
	}

	void Start()
	{
		LoadPlayer();
		Application.targetFrameRate = 120; 
		this.skin.sprite = ChangeSkin.instance.GetSkin();
	}
	public void SetBestScore(int newScore)
	{
		_bestScore = newScore;
	}

	public int GetPoints()
	{
		return _bestScore;
	}

	public int GetMoney()
	{
		return _money;
	}

	public void AddMoney(int points)
	{
		_money = _money + points;
		SaveSystem.SavePlayer(this);
	}

	public int GetBestScore()
	{
		return _bestScore;
	}

	public void ChangeBestScore(int score)
	{
		
		_bestScore = score;
		SaveSystem.SavePlayer(this);
	
	}

	public Sprite GetSkin()
	{
		return skin.sprite;
	}

	public void AddSkin(int position)
	{
		listOfSkins[position] = true;
		Debug.Log("Am Salvat cu succes");
		SaveSystem.SavePlayer(this);
	}

}

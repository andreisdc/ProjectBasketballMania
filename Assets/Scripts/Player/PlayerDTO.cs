using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDTO : MonoBehaviour
{
    public static PlayerDTO instance;
    public SpriteRenderer skin;
    public int score = 0;

	private void Awake()
	{
        instance = this;
	}
	void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void SetSkin(Sprite skinPlayer)
    {
       
        skin.sprite = skinPlayer;
	}

    public void AddPoints()
    {
        score += 1;
    }

    public int GetPoints()
    {
        return score;
	}


}

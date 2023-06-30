using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ChangeSkin : MonoBehaviour
{
	public static ChangeSkin instance; 
	public SpriteRenderer image;

	private void Awake()
	{
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			DontDestroyOnLoad(this.gameObject);
		}

	}

	public void Update()
	{
		
	}

	public Sprite GetSkin()
	{
		return image.sprite;
	}

	public void SetProfilePicture(Sprite imageSource)
	{
		image.sprite = imageSource;
	}
}

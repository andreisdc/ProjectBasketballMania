using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using static Unity.Collections.AllocatorManager;

public class SceneLoader : MonoBehaviour
{
	public Image image;
	public void LoadSceneInSkins()
	{
		SceneManager.LoadScene("InSkins");
	}
	public void LoadSceneInGame()
	{

		SceneManager.LoadScene("InGame");
		if (ClickEvent.instance != null)
		{
			if (ClickEvent.instance.click % 2 == 0)
			{
				ClickEvent.instance.interstitialAd.ShowAd();
			}

			ClickEvent.instance.click = ClickEvent.instance.click + 1;
			Debug.Log(ClickEvent.instance.click.ToString());
		}
	}
	public void LoadSceneMainMenu()
	{
		SceneManager.LoadScene("MainMenu");

	}
	public void LoadSceneInAdd()
	{
		SceneManager.LoadScene("InAdd");
	}

	public void LoadSceneInShop()
	{
		SceneManager.LoadScene("InShop");

	}

	public void LoadSceneInSelectMode()
	{
		SceneManager.LoadScene("InSelectMode");
	}

	public void LoadSceneInChallengeMode()
	{
		SceneManager.LoadScene("InChMode");

	}
	public void LoadSceneInInstagram()
	{
		Application.OpenURL("https://www.instagram.com/pontic.studio/");

	}


}
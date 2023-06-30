using System;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ApplicationManager : MonoBehaviour
	{
		private static ApplicationManager instance;

		private void Awake()
		{
			if (instance != null && instance != this)
			{
				
				Destroy(gameObject);
				return;
			}

			instance = this;
			DontDestroyOnLoad(gameObject);
		}

		private void Update()
		{
			if (Input.GetKey(KeyCode.Escape))
			{
				CloseApplication();
			}
		}

		private void CloseApplication()
		{
#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_ANDROID
            AndroidJavaObject activity =
               new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
            activity.Call<bool>("moveTaskToBack", true);
#elif UNITY_IOS
            Application.Quit();
#endif

			
		}
	}
}

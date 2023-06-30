using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class AudioManager : MonoBehaviour
	{
		public AudioSource audioSource;

		private static AudioManager instance;
		public static AudioManager Instance => instance;

		public bool isMuted = false;
		private bool isPaused = false;


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
		void Start()
		{
        
		}

		private void Update()
		{
			
		}

		
		public void ToggleMute()
		{
			isMuted = !isMuted;

			AudioListener.volume = isMuted ? 0f : 1f;
		}


	}
}

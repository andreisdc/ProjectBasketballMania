using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts.ShowThings
{
	public class AudioManagement : MonoBehaviour
	{
		public Image MuteImage;
		public Sprite MutedSprite;
		public Sprite UnmutedSprite;

		private static bool isMuted = false;

		void Start()
		{
			UpdateMuteImage();
		}

		void Update()
		{
			
		}

		public void Mute()
		{
			AudioManager.Instance.ToggleMute();
			isMuted = !isMuted;
			UpdateMuteImage();
		}

		private void UpdateMuteImage()
		{
			MuteImage.sprite = isMuted ? MutedSprite : UnmutedSprite;
		}
	}
}
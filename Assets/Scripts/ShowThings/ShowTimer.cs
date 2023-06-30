using TMPro;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ShowTimer : MonoBehaviour
	{

		public TextMeshProUGUI text;
    
		void Start()
		{    
		}

		void Update()
		{
			DisplayTime(Timer.instance.GetTimerValue());      
		}

		void DisplayTime(float timeValue)
		{
			if(timeValue < 0)
			{
				timeValue = 0; 
			}
			else{

			}

			float seconds = Mathf.FloorToInt(timeValue % 60);
			float milisecond = timeValue % 1 * 1000;

			text.text = string.Format("{0:00}:{1:000}", seconds,milisecond);
		}
	}
}

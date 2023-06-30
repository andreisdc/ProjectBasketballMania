using TMPro;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ShowTimerDinamic : MonoBehaviour
	{
		public TextMeshProUGUI text;
		public static ShowTimerDinamic instance;
		public float timePassed;

		void Start()
		{
			timePassed = Time.time;
			timePassed = 0;
		}

		void Update()
		{

			timePassed += Time.deltaTime;
			if (timePassed < 60)
			{
				text.text = Mathf.FloorToInt(timePassed % 60).ToString();
			}
			else if (timePassed < 3600)
			{
				float minutes = Mathf.FloorToInt(timePassed / 60);
				float seconds = Mathf.FloorToInt(timePassed % 60);
				text.text = string.Format("{0:0}:{1:00}", minutes, seconds);
			}
			else
			{
				float hours = Mathf.FloorToInt(timePassed / 3600);
				float minutes = Mathf.FloorToInt((timePassed % 3600) / 60);
				float seconds = Mathf.FloorToInt((timePassed % 3600) % 60);
				text.text = string.Format("{0:0}:{1:00}:{2:0}", hours, minutes, seconds);
			}
		}
	}
}
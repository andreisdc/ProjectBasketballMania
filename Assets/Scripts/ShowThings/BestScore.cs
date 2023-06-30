using TMPro;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class BestScore : MonoBehaviour
	{
		public TextMeshProUGUI text;


		void Start()
		{

		}
		// Update is called once per frame
		void Update()
		{
           
			text.text = Player.instacne.GetBestScore().ToString();
		}
	}
}

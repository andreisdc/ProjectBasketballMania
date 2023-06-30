using TMPro;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class Money : MonoBehaviour
	{

		public TextMeshProUGUI text;
    
		void Start()
		{
			text.text = Player.instacne.GetMoney().ToString();
		}

		// Update is called once per frame
		void Update()
		{
		}
	}
}

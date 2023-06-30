using TMPro;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ShowScore : MonoBehaviour
	{
		public TextMeshProUGUI text;

		void Start()
		{       
           
		}

		// Update is called once per frame
		void Update()
		{
			text.text = PlayerDTO.instance.GetPoints().ToString();
		}
	}
}

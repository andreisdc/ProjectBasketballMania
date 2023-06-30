using TMPro;
using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ShowPanel : MonoBehaviour
	{

		public GameObject Panel;
		public GameObject button1;
		public GameObject button2;
		public GameObject textNewBestScore;
		public GameObject[] listOfBox;
		private bool AddMoney = false;
  
		void Start()
		{
			Panel.SetActive(false);
			button1.SetActive(true);
			button2.SetActive(true);
			textNewBestScore.SetActive(false);
		}

		void Update()
		{
    

			if (Timer.instance.GetTimerValue() == 0)
			{
				if (PlayerDTO.instance.GetPoints() > Player.instacne.GetBestScore())
				{
					textNewBestScore.SetActive(true);
					Player.instacne.ChangeBestScore(PlayerDTO.instance.GetPoints());
				}

				for (int i = 0; i < listOfBox.Length; i++)
				{
					listOfBox[i].SetActive(false);
				}

				Panel.SetActive(true);
				button1.SetActive(false);
				button2.SetActive(false);

				if (AddMoney == false)
				{
					Player.instacne.AddMoney(PlayerDTO.instance.GetPoints());
					AddMoney = true;
				}
				
			}
		}
	}
}

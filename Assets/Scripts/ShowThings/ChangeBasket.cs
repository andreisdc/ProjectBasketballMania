using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.ShowThings
{
	public class ChangeBasket : MonoBehaviour
	{
		public List<GameObject> listOfBasket;
		public static ChangeBasket instance;
		public int x;
		public bool partition;
		void Start()
		{
			instance = this;
			DisableList();
			x = Random.RandomRange(0, 9);
			listOfBasket[x].SetActive(true);
			if (x > 5)
			{
				partition = false;
			}
			else
			{
				partition = true;
			}


		}

		// Update is called once per frame
		void Update()
		{
        
		}

		public void DisableList()
		{
			foreach(var elem in listOfBasket)
			{
				elem.SetActive(false);
			}
		}

		public void Change()
		{
			DisableList();
			if (partition == false)
			{

				x = Random.RandomRange(0, 4);
				listOfBasket[x].SetActive(true);
				partition = true;

			}else
			if (partition == true)
			{

				x = Random.RandomRange(5, 9);
				listOfBasket[x].SetActive(true);
				partition = false;
			}
		}

	}
}
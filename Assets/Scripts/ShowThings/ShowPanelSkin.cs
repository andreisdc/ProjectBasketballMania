using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowPanel1 : MonoBehaviour
{
	public List<GameObject> ListOfPanels;
	public static int Contor = 1;



	void Start()
	{
		Contor = 0;

		foreach (GameObject VARIABLE in ListOfPanels)
		{
			VARIABLE.SetActive(false);
		}

		ListOfPanels[Contor].SetActive(true);

	}


	void Update()
	{

	}

	public void ChangeUp()
    {
	    Contor++;
	    if (Contor > ListOfPanels.Count - 1)
	    {
		    Contor = 0;
	    }
	    foreach (GameObject VARIABLE in ListOfPanels)
	    {
		    VARIABLE.SetActive(false);
	    }
	    ListOfPanels[Contor].SetActive(true);

	}
	public void ChangeDown()
    {
	    Contor--;
	    if (Contor < 0)
	    {
		    Contor = ListOfPanels.Count - 1;
	    }
	    foreach (GameObject VARIABLE in ListOfPanels)
	    {
		    VARIABLE.SetActive(false);
	    }
		ListOfPanels[Contor].SetActive(true);
    }
}

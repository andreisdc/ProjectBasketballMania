using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadInGame : MonoBehaviour
{

    public static LoadInGame instance;
    public GameObject[] listBasketLoad;
    public int x;
    public int k;
    void Start()
    {
        x = Random.Range(0, 9);
        if(x > 5)
        {
            k = 0;
		}
        else
        {
            k = 1;
		}
        foreach(var y in listBasketLoad)
        {
            y.SetActive(false);
		}

        LoadFirstBasket();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("escape"))
        {
            Application.Quit();
		}
    }

    public void LoadFirstBasket()
    {
        listBasketLoad[x].SetActive(true);
	}
}

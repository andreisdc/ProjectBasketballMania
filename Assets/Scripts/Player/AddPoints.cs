using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.ShowThings;
using UnityEngine;

public class AddPoints : MonoBehaviour
{
    public int x;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        PlayerDTO.instance.AddPoints();
        ChangeBasket.instance.Change();

    }
}

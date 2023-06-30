using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
	public GameObject panel;
	public GameObject button1;
	public GameObject button2;
	public GameObject Generator;
	void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{

		if (collision.gameObject.tag == "player")
		{
			Destroy(gameObject);
			Debug.Log("hit");
			panel.SetActive(true);
			Destroy(Generator.GetComponent<TriunghiGenerator>());
			button1.SetActive(false);
			button2.SetActive(false);
		}

	}
}

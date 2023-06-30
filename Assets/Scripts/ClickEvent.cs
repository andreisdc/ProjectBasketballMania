using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickEvent : MonoBehaviour
{
	public static ClickEvent instance;
	public InterstitialAd interstitialAd;
	public int click = 0;

	void Start()
	{ 
		interstitialAd = FindObjectOfType<InterstitialAd>();
		instance = this;
	}

    // Update is called once per frame
   

    private void Awake()
    {
	    if (instance != null && instance != this)
	    {

		    Destroy(gameObject);
		    return;
	    }

	    instance = this;
	    DontDestroyOnLoad(gameObject);
    }
}

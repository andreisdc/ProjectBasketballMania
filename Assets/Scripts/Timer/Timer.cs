using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static Timer instance;
    public float timerValue = 20;
 
	public void Awake()
	{
		instance = this;
	}

	public void Update()
	{
		if(timerValue > 0){
			timerValue -= Time.deltaTime;
		}
		else{
			timerValue = 0;
		}
	}

	public float GetTimerValue()
	{
		return timerValue;
	}
	public void AddPoints()
	{
		timerValue += 2f;
	}
}

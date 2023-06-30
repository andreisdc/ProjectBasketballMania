using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChalangeManager : MonoBehaviour
{
	public float timeChalange = 10;
	public float timePause = 10;
	public void Update()
	{
		if (timeChalange > 0  && timePause > 0)
		{
			timeChalange -= Time.deltaTime;
		}
		else if(timeChalange <= 0 && timePause > 0)
		{
			timePause -= Time.deltaTime;
			timeChalange = 0;
		}else if(timeChalange <= 0 && timePause <= 0)
		{
			
			ResetChalange();
			ResetPause();
		}
	}

	public void ResetChalange()
	{
		timeChalange = 10;
	}
	public void ResetPause()
	{
		timePause = 10;
	}
}

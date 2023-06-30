using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;
using Vector2 = UnityEngine.Vector2;
using System;
using Unity.IO.LowLevel.Unsafe;

public class MiscareObstacol : MonoBehaviour
{

	public float vitezaCaderii = 5f;
	private Rigidbody2D rb;
	public Vector3 pozitieInitiala;
	public float zonaResetare;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		pozitieInitiala = rb.position;
	}

	void Update()
	{
		rb.velocity = new Vector3(0, vitezaCaderii, 0);
	}
}

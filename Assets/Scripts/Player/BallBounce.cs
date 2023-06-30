using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
	public Rigidbody2D player;

	Vector3 lastVelocity;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	    lastVelocity = player.velocity;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        var speed = lastVelocity.magnitude;
        var direction = Vector3.Reflect(lastVelocity.normalized, coll.contacts[0].normal);
        player.velocity = direction * Mathf.Max(speed /2, 0f);
    }
}

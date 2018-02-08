using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(AudioSource))]
public class Ball : MonoBehaviour {

    //Components need for the ball
    Rigidbody2D ballRb;
    AudioSource audioSource;
    //Current Velocity
    Vector2 currentVelocity = new Vector2(-2.0f, 0.0f);
    //Maximum Speed;
    public float MaximumSpeed = 5.0f;

	// Use this for initialization
	void Start () {
        //Grab the components from the Game Object
        ballRb = GetComponent<Rigidbody2D>();
        audioSource=GetComponent<AudioSource>();
        //Set Random Velocity from -Max Speed to Max Speed
        currentVelocity.x = Random.Range(-MaximumSpeed, MaximumSpeed);
        currentVelocity.y = Random.Range(-MaximumSpeed, MaximumSpeed);
        ballRb.velocity = currentVelocity;
	}


    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Play Audio if there is a collision
        audioSource.Play();

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class Bat : MonoBehaviour
{
    //The Bat Axis controller
    public string VerticalAxisName = "P1_VerticalAxis";
    //Bat Speed
    public float speed = 5.0f;
    //RigidBody
    private Rigidbody2D rb;

    private void Start()
    {
        //Get the component
        rb = GetComponent<Rigidbody2D>();    
    }

    private void FixedUpdate()
    {
        //Get the Axis
        float axisValue = Input.GetAxis(VerticalAxisName);
        //Calculate the new velocity
        Vector2 velocity = axisValue * Vector2.up * speed;
        Move(velocity);
    }

    //Move function
    public void Move(Vector2 amount)
    {
        rb.velocity = amount;
    }
}

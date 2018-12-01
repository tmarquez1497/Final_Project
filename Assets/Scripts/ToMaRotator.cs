using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMaRotator : MonoBehaviour
{

    public float speed;
    

    private Rigidbody2D rb2D;



    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        
    }

    private void FixedUpdate()
    {
        rb2D.MoveRotation(rb2D.rotation + speed * Time.fixedDeltaTime);
    }
}
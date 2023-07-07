using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 5f;

    public Camera cam;

    Vector2 movment;
    Vector2 mousePos;

    void Update()
    {
       movment.x = Input.GetAxisRaw("Horizontal");
       movment.y = Input.GetAxisRaw("Vertical");

       mousePos = cam.ScreenToWorldPoint(Input.mousePosition);

    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movment * speed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
    }

}

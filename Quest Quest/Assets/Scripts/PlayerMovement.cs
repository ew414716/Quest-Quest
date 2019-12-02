using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 40f;
    public Rigidbody2D rb;

    public CharacterController controller;

    void Start ()
    {
        controller = GetComponent<CharacterController>();
    }

    public void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 tempVect = new Vector3(h, v, 0);
        tempVect = tempVect.normalized * runSpeed * Time.deltaTime;
        rb.MovePosition(rb.transform.position + tempVect);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Teleport")
        {
            transform.position = col.transform.GetChild(0).position;
        }
    }
}

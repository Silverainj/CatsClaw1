using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AeliaMovement : MonoBehaviour
{
    Rigidbody2D rb; //access sto rigid body

    public float speed = 3; //Sprite Speed?????
    public float jump_speed = 2; //Jump Speed??????
    public float acc = 2; //epitaxinsi gia fixedupdate
    //public float x;
    public float limit = 15;
    public float neglimit = -15;
    public float limity = 4;
    //public float neglimity = -4;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        transform.Translate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= limit)
        {
            Vector3 v = transform.position;
            v.x = limit;
            transform.position = v;
        }

        if (transform.position.x <= neglimit)
        {
            Vector3 v = transform.position;
            v.x = neglimit;
            transform.position = v;
        }

        if (transform.position.y >= limity)
        {
            Vector3 v = transform.position;
            v.y = limity;
            transform.position = v;
        }

        /*if (transform.position.y <= neglimity)
        {
            Vector3 v = transform.position;
            v.y = neglimity;
            transform.position = v;
        }*/


        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0, Space.World);
        //transform.Translate(0, Input.GetAxis("Vertical") * speed * Time.deltaTime, 0);
        if (Input.GetButtonDown("Jump"))
        {
            //transform.Translate(0, jump_speed, 0, Space.World);

            rb.velocity += new Vector2(0, jump_speed);
        }


        if (Input.GetAxis("Horizontal") * speed * Time.deltaTime > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetAxis("Horizontal") * speed * Time.deltaTime < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }


    }
    void FixedUpdate()
    {

        //rb.velocity += new Vector2(Input.GetAxis("Horizontal") * acc * Time.fixedDeltaTime, 0);
        /*x = speed * acc;
        if (x < 2)
        {
            rb.velocity += new Vector2(Input.GetAxis("Horizontal") * x * Time.fixedDeltaTime, 0);
        }
        if (x >= 2)
        {
            rb.velocity += new Vector2(Input.GetAxis("Horizontal") * 6 * Time.fixedDeltaTime, 0);

            x = 0;
        }*/

    }




}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    public float rotationSpeed = 50;
    public Animator anim;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");// -1 1
        //if (Mathf.Abs(y) > 0.1f)
        //    anim.SetBool("isWalking", true);
        //else
        //    anim.SetBool("isWalking", false);
        anim.SetFloat("speed", Mathf.Abs(y));
        transform.Translate(Vector3.forward * y * speed * Time.deltaTime);
        transform.Rotate(Vector3.up * x * rotationSpeed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("shoot");
        }
    }
}

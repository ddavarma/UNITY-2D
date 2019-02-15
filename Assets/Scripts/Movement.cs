using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D cl;
    Animator ad;
    public GameObject bulletpos, rightbullet;

    void Start()
    {
        cl = GetComponent<Rigidbody2D>();
        ad = GetComponent<Animator>();
    }

    void Update()
    {
        ad.SetBool("Walk", false);
        ad.SetBool("Shoot", false);
        //ad.SetBool("Runshoot", false);
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");
        cl.velocity = new Vector2(move  * 5f, jump*10);
        if((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow)))
        {

            //if (Input.GetKey(KeyCode.G) && Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))
            //{
            //    ad.SetBool("Walk", false);
            //    ad.SetBool("Runshoot", true);
            //    Instantiate(rightbullet, bulletpos.transform.position, bulletpos.transform.rotation);
            //}
            ad.SetBool("Walk", true);
            //ad.SetBool("Runshoot", true);
            //Instantiate(rightbullet, bulletpos.transform.position, bulletpos.transform.rotation);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            ad.SetBool("Shoot", true);
            Instantiate(rightbullet, bulletpos.transform.position, bulletpos.transform.rotation);
        }

        //if (Input.GetKey(KeyCode.F))
        //        {
        //    ad.SetBool("Runshoot", true);
        //    Instantiate(rightbullet, bulletpos.transform.position, bulletpos.transform.rotation);
        //}
    }
   
}

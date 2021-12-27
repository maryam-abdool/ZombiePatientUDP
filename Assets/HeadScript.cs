using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadScript : MonoBehaviour
{

    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    /*void OnTriggerEnter(Collider other)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsHead", one);
        Debug.Log("head enter");
    }
    void OnTriggerStay(Collider other)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsHead", one);
        Debug.Log("head stay");
    }

    void OnTriggerExit(Collider other)
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        float zero = 0.0F;
        anim.SetFloat("IsHead", zero);
        Debug.Log("head exit");
    }*/


    void OnCollisionEnter(Collision collision)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        if (collision.gameObject.name == "Cube")
        {
            Debug.Log(collision.collider.name);
            float one = 1.0F;
            anim.SetFloat("IsHead", one);
            Debug.Log("head enter");
            Debug.Log(collision.gameObject.name);
        }

    }

    /*void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //If your mouse hovers over the GameObject with the script attached, output this message
            float one = 1.0F;
            anim.SetFloat("IsHead", one);
            Debug.Log("head stay");
        }

    }*/

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //The mouse is no longer hovering over the GameObject so output this message each frame
            float zero = 0.0F;
            anim.SetFloat("IsHead", zero);
            Debug.Log("head exit");
        }
    }

    /*void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsHead", one);
    }*/
    /*void OnMouseExit()
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        float zero = 0.0F;
        anim.SetFloat("IsHead", zero);
    }*/
}

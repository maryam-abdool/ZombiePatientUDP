using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyScript : MonoBehaviour
{
    Animator anim;

    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
    }

    /*void OnTriggerEnter(Collider other)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsBody", one);
        Debug.Log("body enter");
    }
    void OnTriggerStay(Collider other)
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsBody", one);
        Debug.Log("body stay");
    }

    void OnTriggerExit(Collider other)
    {
        //The mouse is no longer hovering over the GameObject so output this message each frame
        float zero = 0.0F;
        anim.SetFloat("IsBody", zero);
        Debug.Log("body exit");
    }*/

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //If your mouse hovers over the GameObject with the script attached, output this message
            float one = 1.0F;
            anim.SetFloat("IsBody", one);
            Debug.Log("body enter");
            Debug.Log(collision.gameObject.name);
        }

    }
    /*void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //If your mouse hovers over the GameObject with the script attached, output this message
            float one = 1.0F;
            anim.SetFloat("IsBody", one);
            Debug.Log("body stay");
        }

    }*/

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Cube")
        {
            //The mouse is no longer hovering over the GameObject so output this message each frame
            float zero = 0.0F;
            anim.SetFloat("IsBody", zero);
            Debug.Log("body exit");
        }
    }

    /*void OnMouseOver()
    {
        //If your mouse hovers over the GameObject with the script attached, output this message
        float one = 1.0F;
        anim.SetFloat("IsBody", one);
    }*/
    /*void OnMouseExit()
        {
            //The mouse is no longer hovering over the GameObject so output this message each frame
            float zero = 0.0F;
            anim.SetFloat("IsBody", zero);
        }*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    Animator anim;
    GameObject udp;
    string lRPacket;
    float x;
    float y;
    float z;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInParent<Animator>();
        udp = GameObject.Find("UDP");
        lRPacket = udp.GetComponent<InputUDP>().lastReceivedPacket;

    }

    // Update is called once per frame
    void Update()
    {
        lRPacket = udp.GetComponent<InputUDP>().lastReceivedPacket;
        /*float x = 4.768F;
        //float y = 4.0F;
        float y = 3.6F;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);*/
        if (lRPacket != null && lRPacket != "")
        {
            float[] positions = System.Array.ConvertAll(lRPacket.Split(';'), float.Parse);
            x = positions[0];
            y = positions[1];
            z = positions[2];
            transform.position = new Vector3(x, y, transform.position.z);
        }


    }

}

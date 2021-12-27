using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EthanScript : MonoBehaviour
{
    Animator anim;
    int fallStateHash = Animator.StringToHash("Base Layer.Z_FallingBack");
    int emStateHash = Animator.StringToHash("Base Layer.Z_Idle");
    public Text textElement;

    public int counter = 0;
    int inState = 0;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //stop zombie from walking at certain position
        float z_XPosition = transform.position.z;
        anim.SetFloat("ZombiePos", z_XPosition);

       // inState = 0;

        AnimatorStateInfo stateInfo = anim.GetCurrentAnimatorStateInfo(0);
        if (stateInfo.nameHash == fallStateHash)
        {
            //zombie flies back when it falls down
            Vector3 temp = transform.position;
            temp.x = 0.0F;
            temp.y = 2.3F;
            temp.z = 4.84F;
            transform.position = temp;

            //counter for correct hits
            inState = 1;
           
        }
        if (stateInfo.nameHash == emStateHash && inState == 1)
        {

            counter += 1;
            textElement.text = counter.ToString();
            inState = 0;
        }

    }

}

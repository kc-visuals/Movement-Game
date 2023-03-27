using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator anim;
    public GameObject guy;
    public Movement mscript;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        mscript = guy.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("w"))
        {
            anim.SetBool("isLeaping",true);
        }
        if (mscript.grounded)
        {
            anim.SetBool("isLeaping",false);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("isLeaping",true);
        }
    }
}

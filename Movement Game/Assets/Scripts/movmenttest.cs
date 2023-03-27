using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movmenttest : MonoBehaviour
{   private Rigidbody rigid;
    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)){
            rigid.AddForce(Vector3.up*100,ForceMode.Impulse);
        }
    }
}

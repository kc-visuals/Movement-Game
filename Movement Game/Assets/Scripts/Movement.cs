using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour
{
    public GameObject player;
    public GameObject trig;
    public float jumpForce = 100.0f;
    public float jumpVal = 10.0f;
    public float chargingP = 0.0f;
    public bool grounded = false;
    public Transform lastCheck;
    private TriggerScript trigscript;

    //private bool Jump = false;
    private Rigidbody rBody;
    private Vector3 startingPosition;
    private Vector3 someVec;


    // Start is called before the first frame update
    void Start()
    {
        rBody = player.GetComponent<Rigidbody>();
        startingPosition = this.transform.position;
        trigscript = trig.GetComponent<TriggerScript>();
        //lastCheck.transform.position = player.transform.position;
        //Physics.gravity = new Vector3(0, -9.8f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 Movement = new Vector3 (Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //player.transform.position += Movement * speed * Time.deltaTime;
        //float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;  
        someVec = rBody.transform.up + rBody.transform.forward;
        //Quaternion target = Quaternion.Euler(0, tiltAroundZ, 0 );
        //transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * smooth);
        if (Input.GetKeyDown(KeyCode.R))
        {
            player.transform.position = lastCheck.transform.position;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            
            if (grounded)
            {
                rBody.AddForce(someVec.normalized * jumpVal, ForceMode.Impulse);
                grounded = false;
            }
        }

        if (Input.GetAxis("Horizontal") == 1)
        {
            this.transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);
        }
        if (Input.GetAxis("Horizontal") == -1)
        {
            this.transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);
        }

        if (grounded)
        {
            //charge jump
            if (Input.GetKey(KeyCode.Space))
            {
                if (chargingP <= .23f)
                {
                chargingP += .1f * Time.deltaTime;
                }
                //Debug.Log("SDf");
            }
            //jump on release
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //Jump = true;
                rBody.AddForce(someVec.normalized * chargingP * jumpForce, ForceMode.Impulse);
                //Debug.Log("sdf");
                chargingP = 0;
                grounded = false;
            }
        }
        if (lastCheck.transform.position != trigscript.thisCheck.transform.position)
        {
            lastCheck.transform.position = trigscript.thisCheck.transform.position;
        }

    }
    /* void FixedUpdate()
     {
         if (Jump)
         {
             rBody.AddForce(someVec * chargingP * jumpForce,  ForceMode.Impulse);
             Jump = false;
             chargingP = 0;
         }
     }*/
    void OnCollisionEnter(Collision col)
    {
        grounded = true;
    }
}

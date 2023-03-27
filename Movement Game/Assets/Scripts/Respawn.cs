using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    //[SerializeField] private Transform checkpoint;
    public Movement mscript;

    void Start()
    {
        mscript = player.GetComponent<Movement>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player.transform.position = mscript.lastCheck.transform.position;
            Physics.SyncTransforms();
            Debug.Log("sdf");
        }
    }
}

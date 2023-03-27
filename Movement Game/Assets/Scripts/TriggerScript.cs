using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Transform thisCheck;
    [SerializeField] private Transform thatCheck;

    void OnTriggerEnter(Collider other)
    {
        thisCheck.transform.position = thatCheck.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalArea : MonoBehaviour
{
    bool inArea = false;
    public GameObject end;
    void OnTriggerEnter(Collider other)
    {
        if (inArea == false)
        {
            inArea = true;
           // end == true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
      //  end == false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondsUpdate : MonoBehaviour
{

    float timeStartoffset = 0;
    bool gotStartTime = false;
     public float speed =0.5f;

    void Update()
    {
        if(!gotStartTime)
        {
            timeStartoffset = Time.realtimeSinceStartup;
            gotStartTime = true;
        }
        this.transform.position = new Vector3(this.transform.position.x,
                                                this.transform.position.y,
                                                   ( Time.realtimeSinceStartup - timeStartoffset)* speed);
    }
}

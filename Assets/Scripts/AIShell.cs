using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiShell : MonoBehaviour
{


     public GameObject explosion;
        Rigibody rb;


    void OnCollisionEnter(Collision col) {

        if (col.gameObject.tag == "tank") {
            GameObject exp = Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(exp, 0.5f);
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigibody>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform..forwardd = rb.velocity;
    }
}

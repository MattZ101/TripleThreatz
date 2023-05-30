using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collider Collider)
    {
        if(gameObject.tag == "Enemy")
        {
            // kill playa
            Destroy(gameObject);
        }
    }
}

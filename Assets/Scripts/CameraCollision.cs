using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    public int maxX = 100;
    public int minX = 0;
    public int maxZ =-70;
    public int minZ = -170;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 100)
        {
            this.transform.Translate(100,transform.position.y,transform.position.z);
            Debug.Log(transform.position);
        }
        if (transform.position.x < 0)
        {
            this.transform.Translate(0, transform.position.y, transform.position.z);
            Debug.Log(transform.position);
        }   
        if (transform.position.z > -70)
        {
            this.transform.Translate(transform.position.x, transform.position.y, -70);
            Debug.Log(transform.position);
        }
        if (transform.position.x < -170)
        {
            this.transform.Translate(transform.position.x, transform.position.y, -170);
            Debug.Log(transform.position);
        }

    }
}

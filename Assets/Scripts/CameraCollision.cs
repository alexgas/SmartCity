using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    [SerializeField]
    private int x;
    private int y;
    private int z;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(this.gameObject.transform.position.x, 0, 100),50,
            Mathf.Clamp(this.gameObject.transform.position.z, -170, -70)
            );
        
        

    }
}

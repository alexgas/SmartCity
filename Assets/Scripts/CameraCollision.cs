using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCollision : MonoBehaviour
{
    [SerializeField]
    private Transform camera;
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
            Mathf.Clamp(camera.position.x, 0, 100),50,
            Mathf.Clamp(camera.position.z, -170, -70)
            );
        
        

    }
}

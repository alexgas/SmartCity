using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateGrid : MonoBehaviour
{
	public GameObject gridItem;
	List<GameObject> grid =  new List<GameObject>();
	
    // Start is called before the first frame update
    void Start()
    {
		Debug.Log("run");
		for (float x = gridItem.transform.position.x; x < (gridItem.transform.position.x + 100); x+=10){
			for (float z = gridItem.transform.position.z; z > (gridItem.transform.position.z - 100); z-=10){
			
		    GameObject gridCopy = Instantiate<GameObject>(gridItem, new Vector3(x,0.4f,z), new Quaternion(0,0,0,0));
	
			grid.Add(gridCopy);
			
			}
		}
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
}

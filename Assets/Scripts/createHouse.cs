using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createHouse : MonoBehaviour
{
	List<GameObject> grid = Global.grid;

    // Start is called before the first frame update
    void Start()
    {
        // StartCoroutine(delayedFunction());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	 void OnCollisionEnter(Collision collision)
    {
		Destroy (this.gameObject);

	}
	
	 void OnMouseDown(){
		Debug.Log("click me");
		Destroy (this.gameObject);

   // this object was clicked - do something
 }
 
	IEnumerator delayedFunction() {
		
		yield return new WaitForSeconds(5);
		Debug.Log(Global.grid[0]);

	}
}

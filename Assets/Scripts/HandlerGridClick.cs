using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlerGridClick : MonoBehaviour
{
	 void OnCollisionEnter(Collision collision)
    {
		Destroy (this.gameObject);
	}
	
	 void OnMouseUp(){
		//Abrir 
		
		GameObject go = GameObject.Find("ScriptSmartCreator");
		SmartsCreator sn = go.GetComponent<SmartsCreator>();

        if(Global.money>=300)
		    sn.openMenu(this.gameObject);

 }
 
}

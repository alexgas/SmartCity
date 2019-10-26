using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartsCreator : MonoBehaviour
{
	GameObject gridItem;
	public List<GameObject> models = new List<GameObject>();
	List<GameObject> smarts = new List<GameObject>();

	 public void openMenu(GameObject gridItemParam){
		
		//smartMenuUi.setActive(true);

		gridItem = gridItemParam;
	 }
	 public void onClickSmartSelection(string tag){
		 //handler del click en menu ui
		 Vector3 pos = new Vector3(gridItem.transform.position.x, gridItem.transform.position.y + 1.33f, gridItem.transform.position.z);
		 GameObject instance = null;
		  switch (tag)
            {
                case "Solar":
					instance = Instantiate(models[0], pos, gridItem.transform.rotation);
					Global.money -= 300;
					break;
				case "Water":
					instance = Instantiate(models[1], pos, gridItem.transform.rotation);
					Global.money -= 300;
					break;
				default: 
					break;
			}
		 if(instance != null){
			Global.smarts.Add(instance);
		 }

 }
 
}

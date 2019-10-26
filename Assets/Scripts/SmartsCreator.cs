using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartsCreator : MonoBehaviour
{
	GameObject gridItem;
	public List<GameObject> models = new List<GameObject>();
	public GameObject panel;
	List<GameObject> smarts = new List<GameObject>();

	void Start() {
		panel.SetActive(false);
	}
	 public void openMenu(GameObject gridItemParam){
		
		panel.SetActive(true);

		gridItem = gridItemParam;
	 }
	  public void closeMenu(){
		panel.SetActive(false);
	 }
	 
	 public void onClickSmartSelection(string tag){
		 //hand	ler del click en menu ui
		panel.SetActive(false);
			Debug.Log("Rotation: " + gridItem.transform.rotation);
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

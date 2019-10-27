using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour, IPointerDownHandler {
	
	// Update is called once per frame
	void Update () {
		
	}

    //void OnPointerDown(PointerEventData ped)
    //{
    //    Debug.Log("Escena due");
    //    SceneManager.LoadScene("SmartCityFinal");
    //}

    public void CargaNivel(string nombreNivel){
		SceneManager.LoadScene(nombreNivel);
	}
	public void Salir () {
		Application.Quit();
	}

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Escena due");
        SceneManager.LoadScene("SmartCityFinal");
        throw new System.NotImplementedException();
    }
}

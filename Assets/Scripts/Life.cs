using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update

    public int contaminacion_inicial = 0;
    int contaminacion;
    public int electricidad_inicial = 50;
    int electricidad;
    int agua;
    public int agua_inicial = 50;
    public Slider contaminacionSlider;
    public Slider elecSlider;
    public Slider aguaSlider;
    

    private void Awake()
    {
        contaminacion = contaminacion_inicial;
        agua = agua_inicial;
        electricidad = electricidad_inicial;

    }

    public void contamina()
    {
		//Debug.Log("Cantidad de casas: " + Global.houses.Count);
        for(int i = 0; i < Global.houses.Count; i++)
        {

         //   Debug.Log(Global.money);
			//Debug.Log("Contaminación: " + contaminacion);
			//Debug.Log("Electricidad: " + electricidad);
			//Debug.Log("Agua: " + agua);
          //  Debug.Log("Tag del elemtento " + i + ": " + Global.houses[i].tag);
            switch (Global.houses[i].tag)
            {
                case "house1":
                    contaminacion += 3;
                    agua -= 3;
                    electricidad -= 3;
					Global.money += 100;
                    break;
                case "house2":
                    contaminacion += 5;
                    agua -= 5;
                    electricidad -= 5;
					Global.money += 150;
                    break;
                case "house3":
                    contaminacion += 10;
                    agua -= 7;
                    electricidad -= 7;
					Global.money += 200;
                    break;
                default:
                    break;
            }
        }

        contaminacionSlider.value = contaminacion;
        aguaSlider.value = agua;
        elecSlider.value = electricidad;
    }

	public void produce() {
	//Debug.Log("Cantidad de casas: " + Global.houses.Count);
        for(int i = 0; i < Global.smarts.Count; i++)
        {

            Debug.Log(Global.money);
			Debug.Log("Contaminación: " + contaminacion);
			Debug.Log("Electricidad: " + electricidad);
			Debug.Log("Agua: " + agua);
         //  Debug.Log("Tag del elemtento " + i + ": " + Global.smarts[i].tag);
            switch (Global.smarts[i].tag)
            {
                case "Solar":
                    contaminacion -= 3;
                    electricidad += 3;
                    break;
                case "Water":
                    contaminacion -= 3;
                    agua += 3;
                    break;
                default:
                    break;
            }
        }

        contaminacionSlider.value = contaminacion;
        aguaSlider.value = agua;
        elecSlider.value = electricidad;
	}
	
    void Start()
    {
        InvokeRepeating("contamina", 0, 5.0f);
		InvokeRepeating("produce", 0, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
		
        if(contaminacion>=100 || agua<=0 || electricidad<=0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

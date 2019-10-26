using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update

    public int contaminacion_inicial = 0;
    public int contaminacion;
    public int electricidad_inicial = 50;
    public int electricidad;
    public int agua;
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
        contaminacion += 1;
        agua -= 1;
        electricidad -= 1;

        contaminacionSlider.value = contaminacion;
        aguaSlider.value = agua;
        elecSlider.value = electricidad;
    }

    void Start()
    {
        InvokeRepeating("contamina", 0, 5.0f);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Life : MonoBehaviour
{
    // Start is called before the first frame update

    public int contaminacion_inicial = 0;
    public int contaminacion;
    public int electricidad_inicial = 100;
    public int agua_inicial = 100;
    public Slider calidadSlider;
    public Slider elecSlider;
    public Slider aguaSlider;
    public float time;

    private void Awake()
    {
        contaminacion = contaminacion_inicial;
        time = Time.time;

    }

    public void contamina()
    {
        
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

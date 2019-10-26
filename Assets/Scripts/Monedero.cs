using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Monedero : MonoBehaviour
{

    public Text dinero;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void contarDinero()
    {
        dinero.text = "" + Global.money;
    }

    // Update is called once per frame
    void Update()
    {
        contarDinero();
    }
}

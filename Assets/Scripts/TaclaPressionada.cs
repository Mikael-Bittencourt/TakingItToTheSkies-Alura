using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TaclaPressionada : MonoBehaviour
{
    [SerializeField]
    private KeyCode tecla;
    [SerializeField]
    private UnityEvent aoPressionarTecla;

    private void Update()
    {
        if(Input.GetKeyDown(this.tecla))
        {
            this.aoPressionarTecla.Invoke();
        }
    }
}

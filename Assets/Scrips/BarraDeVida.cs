using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarraDeVida : MonoBehaviour
{
    public Image BarraDevida;
    public float maximavida;
    public float vidaActual;

    // Start is called before the first frame update
    void Start()
    {
        vidaActual = maximavida;
    }

    // Update is called once per frame
    void UpdateLifeBar()
    {
        float fillAllmount = vidaActual / maximavida;
        BarraDevida.fillAmount = fillAllmount;
    }
    public void PerderDaño()
    {
        vidaActual--;
        UpdateLifeBar();
    }
    public void AumentarVida()
    {
        vidaActual++;
        UpdateLifeBar();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VidaJugador : MonoBehaviour
{
    [SerializeField] private float Vida;
    [SerializeField] private float VidaMax;
    [SerializeField] public BarraDeVida BarraVida;

    private void Start()
    {
        Vida = VidaMax;
    }

    public void TomarDa�o(float Da�o)
    {
        Vida -= Da�o;
        BarraVida.PerderDa�o();

        if (Vida <= 0)
        {
            SceneManager.LoadScene("Game over");
        }
    }
   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ItemVida")) 
        {
            Vida++;
            BarraVida.AumentarVida();
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntos : MonoBehaviour
{
    float puntos;
     public TextMeshProUGUI Texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntos += Time.deltaTime;
        Texto.text = puntos.ToString("0");
    }
}

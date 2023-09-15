
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabelaPeriodica : MonoBehaviour
{
    public int contadorElementos = 0; // Contador de elementos detectados

    private void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que entrou em contato tem a tag "elemento"
        if (other.CompareTag("elemento"))
        {
            contadorElementos++; // Incrementa o contador
        }
    }
}
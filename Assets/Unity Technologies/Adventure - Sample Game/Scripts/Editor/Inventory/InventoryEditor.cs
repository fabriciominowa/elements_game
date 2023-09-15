using UnityEngine;
using UnityEditor;


public class InventoryEditor : Editor
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
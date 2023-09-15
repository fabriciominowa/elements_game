using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorText : MonoBehaviour
{
    public int quantidadeText = 0; // Vari�vel que armazena a quantidade de objetos do tipo Text na tela

    // Fun��o chamada ao iniciar o script
    void Start()
    {
        // Encontra todos os objetos do tipo Text na cena e adiciona � vari�vel "quantidadeText"
        Text[] textos = FindObjectsOfType<Text>();
        quantidadeText = textos.Length;
    }

    // Fun��o chamada a cada frame
    void Update()
    {
        // Verifica se a quantidade de objetos do tipo Text mudou desde a �ltima atualiza��o
        Text[] textos = FindObjectsOfType<Text>();
        if (textos.Length != quantidadeText)
        {
            // Atualiza a vari�vel "quantidadeText"
            quantidadeText = textos.Length;

            // Exibe a nova quantidade na tela
            Debug.Log("Quantidade de objetos do tipo Text: " + quantidadeText);
        }
    }
}

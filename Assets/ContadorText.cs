using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContadorText : MonoBehaviour
{
    public int quantidadeText = 0; // Variável que armazena a quantidade de objetos do tipo Text na tela

    // Função chamada ao iniciar o script
    void Start()
    {
        // Encontra todos os objetos do tipo Text na cena e adiciona à variável "quantidadeText"
        Text[] textos = FindObjectsOfType<Text>();
        quantidadeText = textos.Length;
    }

    // Função chamada a cada frame
    void Update()
    {
        // Verifica se a quantidade de objetos do tipo Text mudou desde a última atualização
        Text[] textos = FindObjectsOfType<Text>();
        if (textos.Length != quantidadeText)
        {
            // Atualiza a variável "quantidadeText"
            quantidadeText = textos.Length;

            // Exibe a nova quantidade na tela
            Debug.Log("Quantidade de objetos do tipo Text: " + quantidadeText);
        }
    }
}

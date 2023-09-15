using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movd : MonoBehaviour

{
    public float moveSpeed = 3.0f; // Velocidade de movimento do personagem

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        movement.Normalize(); // Normaliza o vetor de movimento para manter a mesma velocidade em todas as direções

        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public Transform target; // Transform do personagem
    public float rotationSpeed = 50.0f; // Velocidade de rota��o da c�mera

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");

        // Rota��o da c�mera em torno do personagem
        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}

        
   







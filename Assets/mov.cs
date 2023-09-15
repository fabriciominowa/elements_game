using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov : MonoBehaviour
{
    public Transform target; // Transform do personagem
    public float rotationSpeed = 50.0f; // Velocidade de rotação da câmera

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");

        // Rotação da câmera em torno do personagem
        transform.RotateAround(target.position, Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}

        
   







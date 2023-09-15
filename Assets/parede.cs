using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parede : MonoBehaviour
{
    public float pushPower = 2.0f;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "Wall")
        {
            Vector3 pushDirection = hit.normal;
            pushDirection.y = 0.0f;

            controller.Move(pushDirection * pushPower);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public Transform alvo;
    RaycastHit hit = new RaycastHit();
    public float mouseX = 0;
    public float mouseY = 0;

    public float distCam;

    public float ajusteCamera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(alvo.position, transform.up, Input.GetAxis("Mouse X"));
        transform.RotateAround(alvo.position, transform.right, Input.GetAxis("Mouse Y"));

        Vector3 rotacao = transform.eulerAngles;
        rotacao.z = 0;
        transform.eulerAngles = rotacao;

        transform.position = alvo.position - transform.forward * distCam;

        if (Physics.Linecast(alvo.position, transform.position, out hit))
        {
            transform.position = hit.point + transform.forward * ajusteCamera;
        }
    }
}
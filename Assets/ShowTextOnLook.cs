using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTextOnLook : MonoBehaviour
{
    public GameObject player;
    public string message;
    public float maxDistance = 10f;

    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponentInChildren<TextMeshProUGUI>();
        textMesh.enabled = false;
    }

    void Update()
    {
        Vector3 playerDirection = player.transform.forward;
        Vector3 objectDirection = transform.position - player.transform.position;

        if (Vector3.Dot(playerDirection, objectDirection) > 0 && objectDirection.magnitude < maxDistance)
        {
            textMesh.enabled = true;
            textMesh.SetText(message);
            transform.LookAt(player.transform.position);
        }
        else
        {
            textMesh.enabled = false;
        }
    }
}

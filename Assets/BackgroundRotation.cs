using UnityEngine;

public class BackgroundRotation : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotationSpeed);
    }
}
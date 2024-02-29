using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    public float skyboxrotationSpeed = 1f;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxrotationSpeed);
    }
}

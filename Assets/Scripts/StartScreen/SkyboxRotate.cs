using UnityEngine;

public class SkyboxRotate : MonoBehaviour
{
    public float skyboxrotationSpeed = 1f;
    //public float exposureSpeed;

    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxrotationSpeed);
        //RenderSettings.skybox.SetFloat("_Exposure", Time.time * exposureSpeed);

        //if(RenderSettings.skybox.GetFloat("Exposure") == 5)
        //{
        //    RenderSettings.skybox.SetFloat("Exposure", 1);
        //}
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    private bool shakeControl = false;

    #region Camera Shake
    public IEnumerator cameraShake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-2f, 2f) * magnitude;
            //float y = Random.Range(originalPos.y-1f, originalPos.y+1f) * magnitude;
            transform.localPosition = new Vector3(x, originalPos.y, originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
        Debug.Log("Camera Shaked");
    }

    public void CameraShakesCall()
    {
        if (!shakeControl)
        {
            StartCoroutine(cameraShake(0.22f, 0.4f));
            shakeControl = true;
        }
    }
    #endregion

}//class
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Loading : MonoBehaviour
{

    public TextMeshProUGUI LoadingText;

    private void Start()
    {
        StartCoroutine("LoadingBar");
    }
    public IEnumerator LoadingBar()
    {
        while (true)
        {
            LoadingText.text = "Loading".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingText.text = "Loading.".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingText.text = "Loading..".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingText.text = "Loading...".ToString();
            yield return new WaitForSecondsRealtime(0.5f);
            LoadingText.text = "Loading....".ToString();
        }
    }
}

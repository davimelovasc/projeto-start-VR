using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.XR;

public class SceneLoader : MonoBehaviour
{
    public Text LoadText;
    public int LoadSeconds;

    public void LoadScene(int index)
    {
        gameObject.SetActive(true);
        StartCoroutine(LoadSceneCoroutine(index));
    }

    private IEnumerator LoadSceneCoroutine(int index)
    {
        var asyncOp = SceneManager.LoadSceneAsync(index);
        asyncOp.allowSceneActivation = false;

#if UNITY_EDITOR
        LoadSeconds = 3;
#endif

        for (int i = 0; i < LoadSeconds; i++)
        {
            var text = $"Por favor coloque o dispositivo no óculos, e em seguida ponha em sua cabeça.\n\nO jogo começará em {LoadSeconds - i} segundos.";
            LoadText.text = text;
            yield return new WaitForSeconds(1);
        }

        XRSettings.LoadDeviceByName("cardboard");
        yield return null;
        XRSettings.enabled = true;


        asyncOp.allowSceneActivation = true;
    }

}

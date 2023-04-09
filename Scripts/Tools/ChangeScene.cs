using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class ChangeScene : MonoBehaviour
{
    public void NextScene(string sceneName) {
        SceneManager.LoadScene(sceneName);
    }

    public void NextScene(int sceneNumber) {
        SceneManager.LoadScene(sceneNumber);
    }
}

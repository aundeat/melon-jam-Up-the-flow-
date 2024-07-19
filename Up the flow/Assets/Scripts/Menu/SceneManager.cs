using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void LoadScene(string _scenename)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_scenename);
    }
    public void Exit()
    {
        Application.Quit();
    }
}

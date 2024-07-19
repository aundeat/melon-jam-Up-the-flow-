using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void SendToVillage(string _scenename)
    {
        SceneManager.LoadScene(_scenename);
    }
    public void Exit()
    {
        Application.Quit();
    }
}

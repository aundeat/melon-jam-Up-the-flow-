using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    [SerializeField] private string _nextScene;
    [SerializeField] private bool isBack;

    private Scene _currentScene;
    public void LoadScene(string _scenename)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(_scenename);
    }
    private Scene CheckCurrentScene()
    {
        _currentScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        return _currentScene;
    }
    public void Exit()
    {
        Application.Quit();
    }
    private void OnCollisionEnter(Collision collision)
    {
        _currentScene = CheckCurrentScene();
        if (isBack) { LoadScene("Village"); }else { LoadScene(_nextScene); }
    }
}

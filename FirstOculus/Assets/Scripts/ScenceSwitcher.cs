using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceSwitcher : MonoBehaviour
{
    public void playButton (string SceneName)
    {
        SceneManager.LoadScene(SceneName);    
    }
}

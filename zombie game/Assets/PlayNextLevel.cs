using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayNextLevel : MonoBehaviour
{
    public string nextLevel;

    public void LevelComplete() 
    {
    SceneManager.LoadScene(nextLevel);
    }
}

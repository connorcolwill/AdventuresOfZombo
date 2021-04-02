using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Instruction3 : MonoBehaviour
{
    public string nextScene;
    public string prevScene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void back()
    {
        SceneManager.LoadScene(prevScene);
    }

    public void next()
    {
        SceneManager.LoadScene(nextScene);
    }
}

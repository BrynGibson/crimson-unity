using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }

    void LoadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
}

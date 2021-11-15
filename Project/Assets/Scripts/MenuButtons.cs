using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour


{

    public GameObject MenuPanel;
    public GameObject LevelSelectPanel;
    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
    }

    public void ShowLevelPanel()
    {
        MenuPanel.SetActive(false);
        LevelSelectPanel.SetActive(true);
    }

    public void ShowMenuPanel()
    {
        MenuPanel.SetActive(true);
        LevelSelectPanel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level_1");
    }
    // Update is called once per frame


    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level_2");
    }
    void Update()
    {
        
    }
}

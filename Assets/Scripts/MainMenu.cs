using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneMangagement;

public class MainMenu : MonoBehaviour
{
    public string firstLevet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene(firstLevel);
    }

    public void OpenOptions()
    {

    }

    public void CloseOptions()
    {

    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }

}

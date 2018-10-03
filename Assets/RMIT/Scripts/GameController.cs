using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public string m_MenuScene;

    public string m_Scenario1Scene;
    public string m_Scenario2Scene;
    public string m_Scenario3Scene;

    private string m_CurrentScene;

    // Use this for initialization
    void Start ()
    {
        m_CurrentScene = m_MenuScene;

        DontDestroyOnLoad(this);
	}

    // Update is called once per frame
    void Update()
    {
        // Q to quit
        if (Input.GetKey("q"))
        {
            Application.Quit();
        }
        else if (Input.GetKey("enter"))
        {
            // Return to main menu
            if (m_CurrentScene != m_MenuScene)
            {
                LoadScene(m_MenuScene);
            }
        }
        else if (Input.GetKey("1"))
        {
            if (m_CurrentScene == m_MenuScene)
            {
                LoadScene(m_Scenario1Scene);
            }
        }
        else if (Input.GetKey("2"))
        {
            if (m_CurrentScene == m_MenuScene)
            {
                LoadScene(m_Scenario2Scene);
            }
        }
        else if (Input.GetKey("3"))
        {
            if (m_CurrentScene == m_MenuScene)
            {
                LoadScene(m_Scenario3Scene);
            }
        }
    }

    void LoadScene(string sceneName)
    {
        //SceneManager.LoadScene(sceneName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManageScenes : MonoBehaviour
{
    [SerializeField]
    ToggleGroup mapSelect;
    public void LoadScene()
    {
        Debug.Log(GetSelectedToggle().name);
        if(GetSelectedToggle().name == "Day") { SceneManager.LoadScene("Park"); }
        if(GetSelectedToggle().name == "Dark") { SceneManager.LoadScene("DarkPark"); }

    }
    public void exit()
    {
        Application.Quit();
    }
    public void mainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void setTimeScale(float setTime)
    {
        Time.timeScale = setTime;
    }
    Toggle GetSelectedToggle()
    {
        Toggle[] toggles = mapSelect.GetComponentsInChildren<Toggle>();
        foreach (var t in toggles)
            if (t.isOn) return t;  //returns selected toggle
        return null;           // if nothing is selected return null
    }
}

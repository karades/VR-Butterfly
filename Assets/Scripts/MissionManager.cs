using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionManager : MonoBehaviour
{
    [SerializeField]
    TMPro.TextMeshProUGUI timeTextMission;
    [SerializeField]
    TMPro.TextMeshProUGUI grabTextMission;

    [SerializeField]
    ShowTimeOnScene showTimeOnScene;

    int grabCount;
    int grabCountNow = 0;
    float timeCount;
    private void Start()
    {
        grabCount = LevelControl.instance.GetScriptable().level;
        timeCount = LevelControl.instance.GetScriptable().level * 10;
    }
    private void Update()
    {
        timeTextMission.text = "Time : " + System.Math.Round(showTimeOnScene.timeFloat).ToString() + "/" + timeCount.ToString();
        if(showTimeOnScene.timeFloat >= timeCount)
        {
            timeTextMission.color = Color.green;

        }
        else
        {
            timeTextMission.color = Color.red;

        }
        grabTextMission.text = "Grab : " + grabCountNow.ToString() + "/" + grabCount.ToString();
        if (grabCountNow >= grabCount)
        {
            grabTextMission.color = Color.green;
        }
        else
        {
            grabTextMission.color = Color.red;
        }

    }

    public void addGrab()
    {
        grabCountNow++;
    }
}

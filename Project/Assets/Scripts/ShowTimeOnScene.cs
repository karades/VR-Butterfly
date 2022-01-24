using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShowTimeOnScene : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI timeText;
    public float timeFloat = 0f;

    // Update is called once per frame
    void Update()
    {
        timeFloat += Time.deltaTime ;
        if (timeText.enabled)
        {
            timeText.text = timeFloat.ToString() + " seconds";
        }
    }
}

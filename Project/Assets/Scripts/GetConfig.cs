using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class GetConfig : MonoBehaviour
    {
        public Slider Quantity;
        public Slider Flutter;
        public Slider Speed;
        public Toggle Glass;

        public Slider Level;

    // Start is called before the first frame update

        public void setConfigValues()
        {
            LevelControl.instance.GetScriptable().quantity = (int)Quantity.value;
            LevelControl.instance.GetScriptable().flutter = Flutter.value;
            LevelControl.instance.GetScriptable().speed = Speed.value;
            LevelControl.instance.GetScriptable().level = (int)Level.value;
            if (Glass.isOn)
            {
                LevelControl.instance.GetScriptable().inGlass = true;
            }
            else{
                LevelControl.instance.GetScriptable().inGlass = false;
            }

        }

    }
       



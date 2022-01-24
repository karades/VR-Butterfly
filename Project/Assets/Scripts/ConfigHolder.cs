using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigHolder : MonoBehaviour
{
    public Slider Quantity;
    public Slider Flutter;
    public Slider Speed;
    public Toggle Glass;
    public void updateSliders()
    {

        Quantity.value = LevelControl.instance.GetScriptable().quantity;
        Flutter.value = LevelControl.instance.GetScriptable().flutter;
        Speed.value = LevelControl.instance.GetScriptable().speed;
        Glass.isOn = LevelControl.instance.GetScriptable().inGlass;
    }

    public void setLevel(int level)
        {
            switch (level)
            {
                case 0:
                    LevelControl.instance.GetScriptable().speed = 0;
                    LevelControl.instance.GetScriptable().flutter = 0;
                    LevelControl.instance.GetScriptable().quantity = 0;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 1:
                    LevelControl.instance.GetScriptable().speed = 0.1f;
                    LevelControl.instance.GetScriptable().flutter = 0.1f;
                    LevelControl.instance.GetScriptable().quantity = 1;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 2:
                    LevelControl.instance.GetScriptable().speed = 0.2f;
                    LevelControl.instance.GetScriptable().flutter = 0.2f;
                    LevelControl.instance.GetScriptable().quantity = 1;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 3:
                    LevelControl.instance.GetScriptable().speed = 0f;
                    LevelControl.instance.GetScriptable().flutter = 0f;
                    LevelControl.instance.GetScriptable().quantity = 2;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 4:
                    LevelControl.instance.GetScriptable().speed = 0.1f;
                    LevelControl.instance.GetScriptable().flutter = 0.1f;
                    LevelControl.instance.GetScriptable().quantity = 2;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 5:
                    LevelControl.instance.GetScriptable().speed = 0.2f;
                    LevelControl.instance.GetScriptable().flutter = 0.2f;
                    LevelControl.instance.GetScriptable().quantity = 2;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 6:
                    LevelControl.instance.GetScriptable().speed = 0.3f;
                    LevelControl.instance.GetScriptable().flutter = 0.3f;
                    LevelControl.instance.GetScriptable().quantity = 2;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 7:
                    LevelControl.instance.GetScriptable().speed = 0.1f;
                    LevelControl.instance.GetScriptable().flutter = 0.1f;
                    LevelControl.instance.GetScriptable().quantity = 3;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 8:
                    LevelControl.instance.GetScriptable().speed = 0.2f;
                    LevelControl.instance.GetScriptable().flutter = 0.2f;
                    LevelControl.instance.GetScriptable().quantity = 3;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 9:
                    LevelControl.instance.GetScriptable().speed = 0.3f;
                    LevelControl.instance.GetScriptable().flutter = 0.3f;
                    LevelControl.instance.GetScriptable().quantity = 3;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 10:
                    LevelControl.instance.GetScriptable().speed = 0;
                    LevelControl.instance.GetScriptable().flutter = 0;
                    LevelControl.instance.GetScriptable().quantity = 1;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 11:
                    LevelControl.instance.GetScriptable().speed = 0.1f;
                    LevelControl.instance.GetScriptable().flutter = 0.1f;
                    LevelControl.instance.GetScriptable().quantity = 1;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 12:
                    LevelControl.instance.GetScriptable().speed = 0.4f;
                    LevelControl.instance.GetScriptable().flutter = 0.4f;
                    LevelControl.instance.GetScriptable().quantity = 1;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 13:
                    LevelControl.instance.GetScriptable().speed = 0.4f;
                    LevelControl.instance.GetScriptable().flutter = 0.4f;
                    LevelControl.instance.GetScriptable().quantity = 3;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 14:
                    LevelControl.instance.GetScriptable().speed = 0.2f;
                    LevelControl.instance.GetScriptable().flutter = 0.2f;
                    LevelControl.instance.GetScriptable().quantity = 5;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 15:
                    LevelControl.instance.GetScriptable().speed = 0.4f;
                    LevelControl.instance.GetScriptable().flutter = 0.4f;
                    LevelControl.instance.GetScriptable().quantity = 5;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 16:
                    LevelControl.instance.GetScriptable().speed = 0.5f;
                    LevelControl.instance.GetScriptable().flutter = 0.5f;
                    LevelControl.instance.GetScriptable().quantity = 7;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 17:
                    LevelControl.instance.GetScriptable().speed = 0.5f;
                    LevelControl.instance.GetScriptable().flutter = 0.5f;
                    LevelControl.instance.GetScriptable().quantity = 10;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 18:
                    LevelControl.instance.GetScriptable().speed = 1f;
                    LevelControl.instance.GetScriptable().flutter = 1;
                    LevelControl.instance.GetScriptable().quantity = 10;
                    LevelControl.instance.GetScriptable().inGlass = true;
                    break;
                case 19:
                    LevelControl.instance.GetScriptable().speed = 1f;
                    LevelControl.instance.GetScriptable().flutter = 1f;
                    LevelControl.instance.GetScriptable().quantity = 10;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
                case 20:
                    LevelControl.instance.GetScriptable().speed = 1;
                    LevelControl.instance.GetScriptable().flutter = 1;
                    LevelControl.instance.GetScriptable().quantity = 20;
                    LevelControl.instance.GetScriptable().inGlass = false;
                    break;
            }
        }
}

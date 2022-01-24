using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelControl : MonoBehaviour
{
    public static LevelControl instance = null; //declare and initialize manager class
    [SerializeField]
    LevelControlScriptable levelControlScriptable;
    [SerializeField]
    ConfigHolder configHolder;

    public Slider level;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
    }

    public LevelControlScriptable GetScriptable()
    {
        return levelControlScriptable;
    }
    public void setQuantity(int quantity)
    {
        levelControlScriptable.quantity = quantity;
    }
    public void setSpeed(float speed)
    {
        levelControlScriptable.speed = speed;
    }
    public void setFlutter(float flutter)
    {
        levelControlScriptable.flutter = flutter;
    }
    public void setGlass(bool isGlass)
    {
        levelControlScriptable.inGlass = isGlass;
    }
    public int getQuantity()
    {
       return levelControlScriptable.quantity;
    }
    public float getSpeed()
    {
       return levelControlScriptable.speed;
    }
    public float getFlutter()
    {
        return levelControlScriptable.flutter;
    }
    public bool getGlass()
    {
        return levelControlScriptable.inGlass;
    }
    public void setLevel()
    {
        configHolder.setLevel((int)level.value);
    }

}






using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ConfigLevel", menuName = "ScriptableObjects/LevelControlScriptableObject")]
public class LevelControlScriptable : ScriptableObject
{
   public float speed = 1;
   public float flutter = 1;
   public int quantity = 1;
   public bool inGlass = true;
   public int level = 0;
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class CreateButterflies : MonoBehaviour
{
    [SerializeField]
    GameObject butterFlyGlassPrefab;
    [SerializeField]
    GameObject butterFlyPrefab;
    GameObject[] allButterflies;
    // Start is called before the first frame update
    [SerializeField]
    List<GameObject> spanws = new List<GameObject>();
    void Start()
    {
        allButterflies = new GameObject[LevelControl.instance.GetScriptable().quantity];
        if(LevelControl.instance.getGlass() == true)
        {
            for (int i = 0; i < LevelControl.instance.GetScriptable().quantity; i++)
            {
                allButterflies[i] = Instantiate(butterFlyGlassPrefab, GameObject.Find("SpawnGlass").transform);
            }
        }
        else
        {

            for (int i = 0; i < LevelControl.instance.GetScriptable().quantity; i++)
            {
                allButterflies[i] = Instantiate(butterFlyPrefab, spanws[Random.Range(0,spanws.Count)].transform);
            }
        }

    }
}

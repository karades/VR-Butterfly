using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationSpeedUp : MonoBehaviour
{

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        setFlutterSpeed();

    }
    void setFlutterSpeed()
    {
        animator = this.gameObject.GetComponent<Animator>();
        animator.SetFloat("AnimationMultiplier", LevelControl.instance.getFlutter()*1.2f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript1 : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger(KeepStr.str);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

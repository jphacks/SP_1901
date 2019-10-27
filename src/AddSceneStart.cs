using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSceneStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AddScene>().Adder();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

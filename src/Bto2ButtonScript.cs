using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bto2ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Bto2Click()
    {
        Debug.Log("押されたよ！");
        SceneManager.LoadScene("2");
    }
}

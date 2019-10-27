using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Fto5ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Fto5Click()
    {
        Debug.Log("次のシーンに行くよ！");
		SceneManager.LoadScene("5");
	}

}

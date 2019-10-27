using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AddScene : MonoBehaviour
{
    public string SceneName;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Adder()
    {
        SceneManager.LoadScene(SceneName, LoadSceneMode.Additive);

    }

    public void Load()
    {
        SceneManager.LoadScene(SceneName);
    }
}

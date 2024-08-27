using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameObject panel;
    public void Master()
    {
        SceneManager.LoadScene("Master");
    }

    public void Sceneone()
    {
        SceneManager.LoadScene("1");
    }

    public void Scenetwo()
    {
        SceneManager.LoadScene("2");
    }

    public void Scenethree()
    {
        SceneManager.LoadScene("3");
    }
}

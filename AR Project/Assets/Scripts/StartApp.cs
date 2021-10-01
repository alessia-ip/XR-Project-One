using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartApp : MonoBehaviour
{
    public void beginApp()
    {
        SceneManager.LoadScene(1);
    }
}

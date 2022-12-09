using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelButton : MonoBehaviour
{
    void Start()
    {
    }
    public void MoveToScene(int SIMULATION)
    {
        SceneManager.LoadScene(SIMULATION);
    }
}
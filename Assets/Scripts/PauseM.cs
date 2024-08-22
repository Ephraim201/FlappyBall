using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseM : MonoBehaviour
{
    public GameObject pausePanel;
    private bool isPaused;

    void Start()
    {
        isPaused = false;
        pausePanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            isPaused = !isPaused;
            pausePanel.SetActive(isPaused);
        }
    }
}

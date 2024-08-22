using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject SoundP;
    public GameObject SoundR;
    private bool isPaused;
    public Jugador player;

    void Start()
    {
        isPaused = false;
        pausePanel.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Escape))
        {
            GameObject newSoundP = Instantiate(SoundP);
            Destroy(newSoundP, 2);
            isPaused = !isPaused;
            pausePanel.SetActive(isPaused);
            Time.timeScale = isPaused ? 0 : 1;
            player.enabled = !isPaused;
        }
    }

    public void Continue()
    {
        isPaused = !isPaused;
        pausePanel.SetActive(isPaused);
        Time.timeScale = isPaused ? 0 : 1;
        player.enabled = !isPaused;
        GameObject newSoundR = Instantiate(SoundR);
        Destroy(newSoundR, 2);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void HomeP()
    {
        Time.timeScale = 1;
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}

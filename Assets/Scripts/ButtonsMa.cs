using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;


public class ButtonsMa : MonoBehaviour
{
    public Transform grid;
    public GameObject baseScore;

    public List<User> usuarios;
    private string urlGetInfo = "https://thegameprojectyes.000webhostapp.com/getinfo.php";

    private void Start()
    {
        StartCoroutine(GetInfo());
    }

    IEnumerator GetInfo()
    {
        UnityWebRequest request = UnityWebRequest.Get(urlGetInfo);
        yield return request.SendWebRequest();
        SplitData(request.downloadHandler.text);
    }
    
    void SplitData(string _data)
    {
        string[] users = _data.Split(new string[] {"<br>"}, System.StringSplitOptions.None);
        for (int i = 0; i < users.Length -1; i++)
        {
            string[] userData = users[i].Split(new string[] {"<-->"}, System.StringSplitOptions.None);
            User newUser = new User(userData[0], int.Parse(userData[1]));
            usuarios.Add(newUser);
        }
        PrintUsers();
    }

    void PrintUsers()
    {
        for (int i = 0; i < usuarios.Count; i++)
        {
            GameObject newUser = Instantiate(baseScore, grid);
            newUser.transform.Find("Nombre").GetComponent<Text>().text = usuarios[i].username;
            newUser.transform.Find("ScoreT").GetComponent<Text>().text = usuarios[i].score.ToString();
        }
    }

    public void Replay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackHome()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

[System.Serializable]
public class User
{
    public string username;
    public int score;

    public User(string _name, int _score)
    {
        username = _name;
        score = _score;
    }
}
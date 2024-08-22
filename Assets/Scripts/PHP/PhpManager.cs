using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PhpManager : MonoBehaviour
{
    private string postURL = "https://thegameprojectyes.000webhostapp.com/setinfo.php";
    private bool canSend;

    void Start()
    {
        canSend = true;
    }

    public void SendScore(InputField _name)
    {
        if (_name.text != "" && canSend == true)
        {
            canSend = false;
            StartCoroutine(SendInfo(_name.text));
        }
        else
        {
            //mensaje de error
        }
    }
    IEnumerator SendInfo(string _username)
    {
        WWWForm form = new WWWForm();
        form.AddField("name", _username);
        form.AddField("score", Jugador.score);
        UnityWebRequest request = UnityWebRequest.Post(postURL, form);
        yield return request.SendWebRequest();
    }
}

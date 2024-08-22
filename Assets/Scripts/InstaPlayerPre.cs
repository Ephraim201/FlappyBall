using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstaPlayerPre : MonoBehaviour
{
    public GameObject JugadorPref;
    void Start()
    {
        GameObject newPlayerPrefa = Instantiate(JugadorPref);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

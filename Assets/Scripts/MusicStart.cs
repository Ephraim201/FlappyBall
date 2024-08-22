using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicStart : MonoBehaviour
{
    public GameObject[] Music;

    void Start()
    {
        Musicaaa();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Musicaaa()
    {
        int Hurt = Random.Range(0, 6);
        switch (Hurt)
        {
            case 0:
                GameObject newMus = Instantiate(Music[1]);
                break;
            case 1:
                GameObject newMus2 = Instantiate(Music[2]);
                break;
            case 2:
                GameObject newMus3 = Instantiate(Music[3]);
                break;
            case 3:
                GameObject newMus4 = Instantiate(Music[4]);
                break;
            case 4:
                GameObject newMus5 = Instantiate(Music[5]);
                break;
            case 5:
                GameObject newMus6 = Instantiate(Music[6]);
                break;
            case 6:
                GameObject newMus7 = Instantiate(Music[7]);
                break;
        }
    }
}

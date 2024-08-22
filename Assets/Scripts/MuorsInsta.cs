using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuorsInsta : MonoBehaviour
{
    public GameObject Muro;
    

    void Start()
    {
        InvokeRepeating("Repe", 3, 2.0f);
    }

    void Update()
    {

    }

    void Repe()
    {
        Instantiate(Muro);
    }


}

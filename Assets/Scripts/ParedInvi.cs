using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedInvi : MonoBehaviour
{
    public Animator Muroo;

    void Start()
    {
    

    }

    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D otherM)
    {
        if (otherM.tag == "Player")
        {
            Muroo.SetBool("DeadAA", true);

        }
    }
}

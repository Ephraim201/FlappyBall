using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculos : MonoBehaviour
{
    private float vel;

    void Start()
    {
        vel = 6.0f;
        transform.position = new Vector2(15.0f, Random.Range(2.66f, -2.62f));
    }

    void Update()
    {
        transform.Translate(Vector2.left * vel * Time.deltaTime);
        if (transform.position.x < -13.17f)
        {
            Destroy(gameObject);
        }
    }

}

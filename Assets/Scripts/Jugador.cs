using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Jugador : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public Animator Playeer;
    public static int score; // =0
    public Text scoreText;
    public static int score2; // =0
    public Text scoreText2;
    public GameObject Explo;
    public GameObject SoundGod;
    public GameObject SSG;

    public GameObject[] UffSound;


    public static bool gameOver;
    public GameObject gameOverPanel;

    void Start()
    {
        score = 0;
        score2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newSS = Instantiate(SSG);
            Destroy(newSS, 2);
            rb.velocity *= 0;
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

        LimitesPanta();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Muro")
        {
            GameObject newExplosion = Instantiate(Explo, transform.position, Quaternion.identity);
            Destroy(newExplosion, 2);
            Destroy(gameObject);
            Uff();
            GOS();
        }

        if (other.tag == "Lared")
        {
            GameObject newSG = Instantiate(SoundGod, transform.position, Quaternion.identity);
            Destroy(newSG, 2);
            score++;
            scoreText.text = score.ToString();
            score2++;
            scoreText2.text = score2.ToString();
        }
    }

    public void GOS()
    {
        gameOver = true;
        gameOverPanel.SetActive(true);
    }

    void Uff()
    {
        int Hurt = Random.Range(0, 3);
        switch (Hurt)
        {
            case 0:
                GameObject newHurt1 = Instantiate(UffSound[1]);
                Destroy(newHurt1, 1);
                break;
            case 1:
                GameObject newHurt2 = Instantiate(UffSound[2]);
                Destroy(newHurt2, 1);
                break;
            case 2:
                GameObject newHurt3 = Instantiate(UffSound[3]);
                Destroy(newHurt3, 1);
                break;
            case 3:
                GameObject newHurt4 = Instantiate(UffSound[4]);
                Destroy(newHurt4, 1);
                break;
        }
    }

    public void LimitesPanta()
    {
        if (transform.position.y < -5.0f)
        {
            Destroy(gameObject);
            GameObject newExplosion = Instantiate(Explo, transform.position, Quaternion.identity);
            Destroy(newExplosion, 2);
            GOS();
            Uff();
        }

        if (transform.position.y > 5.0f)
        {
            Destroy(gameObject);
            GameObject newExplosion = Instantiate(Explo, transform.position, Quaternion.identity);
            Destroy(newExplosion, 2);
            GOS();
            Uff();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject playerExplosion;
    public int scoreValue;
    public Text scoreText;
    private GameController gameController;

    private void Start()
    {
        scoreValue = 0;
        SetScoreText();
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if(gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<GameController>();
        }
        if(gameControllerObject = null)
        {
            Debug.Log("Cannot find 'GameController' Script");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Boundary")
        {
            return;
        }
        Instantiate(explosion, transform.position, transform.rotation);
        if (other.tag == "Player")
        {
            Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
        }
        if(other.gameObject.CompareTag("Asteroid"))
        {
            scoreValue = scoreValue + 10;
            SetScoreText();

        }
        //gameController.AddScore(scoreValue);
        Destroy(other.gameObject);
        Destroy(gameObject);
    }

    void SetScoreText()
    {
        scoreText.text = "Score: " + scoreValue.ToString();
    }

}

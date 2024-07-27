using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickups : MonoBehaviour
{
    public int score;   
    public Text scoreText;

    public ParticleSystem pickup;

    void Start()
    {
      pickup.Stop();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("coin")) OnCoinTriggerEnter(other);
    }

    void OnCoinTriggerEnter (Collider other) {
        score++;
        scoreText.text = score.ToString();
        Destroy(other.gameObject);

        pickup.Play();
    }
}

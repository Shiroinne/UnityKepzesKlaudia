using System;
using UnityEngine;
using TMPro;

public class Collector : MonoBehaviour
{
    [SerializeField] int collectedValue;
    [SerializeField] TMP_Text scoreText;

    void Start()
    {
        UpdateScore();
    }

    void OnTriggerEnter(Collider other)
    {
        Collectable collectable = other.GetComponent<Collectable>();
        if (collectable != null)
        {
            collectedValue += collectable.value;
            collectable.Collect();

            UpdateScore();
        }

    }
    void UpdateScore()
    {
        if(scoreText != null)
            scoreText.text = $"Score: {collectedValue}";
    }
    public void RestartCollectable()
    {
        collectedValue = 0;
        UpdateScore();
    }
}

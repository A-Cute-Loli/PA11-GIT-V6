using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    [SerializeField] private Text ScoreText;
    private int Score;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
            Score++;
            ScoreText.GetComponent<Text>().text = "Score: " + Score;
        }
    }

}

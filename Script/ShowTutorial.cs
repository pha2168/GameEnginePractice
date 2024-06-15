using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour
{
    public GameObject tutorialCanvas;

    void Start()
    {
        if (tutorialCanvas != null)
        {
            tutorialCanvas.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            tutorialCanvas.SetActive(true);
            gameObject.SetActive(false);

        }
    }

}

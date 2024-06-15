using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerEnd : MonoBehaviour
{
    public GameObject videoCanvas;
    public Camera mainCamera;
    private GameObject persistantObject;

    void Start()
    {
        persistantObject = GameObject.FindWithTag("PersistantObject");
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (videoCanvas != null)
            {
                videoCanvas.SetActive(true);
            }

            if (mainCamera != null)
            {
                AudioSource audioSource = mainCamera.GetComponent<AudioSource>();
                if (audioSource != null)
                {
                    audioSource.enabled = false;
                }
            }

            if (persistantObject != null)
            {
                SceneManager.MoveGameObjectToScene(persistantObject, SceneManager.GetActiveScene());
                Destroy(persistantObject);
            }
        }
    }
}

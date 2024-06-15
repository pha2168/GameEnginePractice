using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObject : MonoBehaviour
{
    private static PersistantObject instance;

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

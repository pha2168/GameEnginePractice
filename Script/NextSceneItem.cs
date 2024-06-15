using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextSceneItem : MonoBehaviour
{
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

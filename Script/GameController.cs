using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObject : MonoBehaviour
{
    private static PersistantObject instance;

    void Awake()
    {
        // 이미 인스턴스가 있으면 파괴
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // 인스턴스가 없으면 유지
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

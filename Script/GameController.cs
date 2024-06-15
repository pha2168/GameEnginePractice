using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObject : MonoBehaviour
{
    private static PersistantObject instance;

    void Awake()
    {
        // �̹� �ν��Ͻ��� ������ �ı�
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        // �ν��Ͻ��� ������ ����
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
}

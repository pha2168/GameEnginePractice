using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public void Quit()
    {
        // ���� ����
        Application.Quit();

        // ���� �����Ϳ��� ���� ���̸� ���� ���ᰡ �������� ���� �� �ֽ��ϴ�.
        // �����Ϳ��� �׽�Ʈ�� ���� �Ʒ� �ּ��� �����ϰ� ����ϼ���.
        //UnityEditor.EditorApplication.isPlaying = false;
    }
}

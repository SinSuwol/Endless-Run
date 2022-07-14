using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resolution : MonoBehaviour
{
    void Start()
    {
        Camera camera = GetComponent<Camera>();

        Rect rect = camera.rect;

                    // ������ �������� ������ ������ ���Ϳ�.
                    // �Ǽ����� ���� �� �ֵ��� �����մϴ�.
        float heigt =((float)Screen.width / Screen.height) / ((float)9/19f);
        float width = 1f / heigt;

        if(heigt < 1)
        {
            rect.height = heigt;
            rect.y = (1f - heigt) / 2f;
        }
        else
        {
            rect.width = width;
            rect.x = (1f - width) / 2f;
        }
        camera.rect = rect;
    }
    private void OnPreCull()
    {
        GL.Clear(true, true, Color.black);
    }
}

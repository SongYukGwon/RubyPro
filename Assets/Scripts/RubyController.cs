using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*QualitySettings.vSyncCount = 0;
        //�ʴ� 10������
        Application.targetFrameRate = 10;*/
    }

    // �����Ӵ� ����Ǵ� �Լ��̹Ƿ� �������� �������� ����󵵵� �۾���.
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector2 position = transform.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;
        transform.position = position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /*QualitySettings.vSyncCount = 0;
        //초당 10프레임
        Application.targetFrameRate = 10;*/
    }

    // 프레임당 실행되는 함수이므로 프레임이 적어지면 실행빈도도 작아짐.
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

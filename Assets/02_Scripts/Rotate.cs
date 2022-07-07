using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int tlqkf = 0;

    public void dkssud()
    {
        Debug.Log(tlqkf);
        tlqkf = tlqkf + 1;
        gkdl();
    }

    public void dkssud1()
    {
        Debug.Log(tlqkf);
        tlqkf = tlqkf - 1;
        gkdl1();
    }

    void gkdl()
    {
        switch (tlqkf)
        {
            case 1:
                Debug.Log("아래");
                transform.Rotate(0, 0, 90); // 입구 아래쪽
                break;
            case 2:
                Debug.Log("오른쪽");
                transform.Rotate(0, 0, 90); // 입구 오른쪽
                break;
            case 3:
                Debug.Log("위쪽");
                transform.Rotate(0, 0, 90); // 입구 위쪽
                break;
            case 4:
                Debug.Log("왼쪽");
                transform.Rotate(0, 0, 90); // 입구 왼쪽
                break;
            case 5:
                tlqkf = 1;
                goto case 1;
        }
    }

    void gkdl1()
    {
        switch (tlqkf)
        {
            case 1:
                Debug.Log("아래");
                transform.Rotate(0, 0, -90); // 입구 아래쪽
                break;
            case 2:
                Debug.Log("오른쪽");
                transform.Rotate(0, 0, -90); // 입구 오른쪽
                break;
            case 3:
                Debug.Log("위쪽");
                transform.Rotate(0, 0, -90); // 입구 위쪽
                break;
            case 4:
                Debug.Log("왼쪽");
                transform.Rotate(0, 0, -90); // 입구 왼쪽
                break;
            case 0:
                tlqkf = 1;
                goto case 1;
        }
    }
}

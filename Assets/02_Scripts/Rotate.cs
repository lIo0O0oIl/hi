using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public int tlqkf = 0;

    public void dkssud()
    {
        tlqkf = tlqkf + 1;
        gkdl();
    }

    public void dkssud1()
    {
        tlqkf = tlqkf - 1;
        gkdl1();
    }

    void gkdl()
    {
        switch (tlqkf)
        {
            case 1:
                transform.Rotate(0, 0, 90); // �Ա� �Ʒ���
                break;
            case 2:
                transform.Rotate(0, 0, 90); // �Ա� ������
                break;
            case 3:
                transform.Rotate(0, 0, 90); // �Ա� ����
                break;
            case 4:
                transform.Rotate(0, 0, 90); // �Ա� ����
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
                transform.Rotate(0, 0, -90); // �Ա� �Ʒ���
                break;
            case 2:
                transform.Rotate(0, 0, -90); // �Ա� ������
                break;
            case 3:
                transform.Rotate(0, 0, -90); // �Ա� ����
                break;
            case 4:
                transform.Rotate(0, 0, -90); // �Ա� ����
                break;
            case 0:
                tlqkf = 1;
                goto case 1;
        }
    }

    bool rotate = false;

    public void test()
    {
        rotate = true;
    }

    int rotatee = 0;

    private void Update()
    {
        transform.Rotate(0f, 0f, 90f * Time.deltaTime);
    }
}

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
                Debug.Log("�Ʒ�");
                transform.Rotate(0, 0, 90); // �Ա� �Ʒ���
                break;
            case 2:
                Debug.Log("������");
                transform.Rotate(0, 0, 90); // �Ա� ������
                break;
            case 3:
                Debug.Log("����");
                transform.Rotate(0, 0, 90); // �Ա� ����
                break;
            case 4:
                Debug.Log("����");
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
                Debug.Log("�Ʒ�");
                transform.Rotate(0, 0, -90); // �Ա� �Ʒ���
                break;
            case 2:
                Debug.Log("������");
                transform.Rotate(0, 0, -90); // �Ա� ������
                break;
            case 3:
                Debug.Log("����");
                transform.Rotate(0, 0, -90); // �Ա� ����
                break;
            case 4:
                Debug.Log("����");
                transform.Rotate(0, 0, -90); // �Ա� ����
                break;
            case 0:
                tlqkf = 1;
                goto case 1;
        }
    }
}

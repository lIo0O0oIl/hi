using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rotate rotate;

    private void Start()
    {
        rotate = FindObjectOfType<Rotate>();
    }

    public void hi()
    {
        rotate.dkssud();
    }
}

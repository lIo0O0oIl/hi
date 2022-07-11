using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    Rotate rotate;

    private void Start()
    {
        rotate = FindObjectOfType<Rotate>();
    }

    public void hihi()
    {
        rotate.test();
    }
}

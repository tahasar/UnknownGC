using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryImpact : MonoBehaviour
{
    private void Awake()
    {
        Destroy(gameObject,0.7f);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(this.transform.parent.gameObject);
    }
}

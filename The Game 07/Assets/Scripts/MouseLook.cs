﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    void Update()
    {
        transform.position = player.transform.position;
    }
}

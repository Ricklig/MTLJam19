﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(pick());
    }

    IEnumerator pick()
    {
        yield return new WaitForSeconds(0.2f);
        gameObject.GetComponent<Pickup>().Work();

    }

}

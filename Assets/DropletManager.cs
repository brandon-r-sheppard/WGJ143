using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropletManager : MonoBehaviour
{
    public Material _r;
    public Material _g;
    public Material _b;

    [Range(1,3)]
    public int type = 3;

    void Update()
    {
        switch (type)
        {
            case 1:
                GetComponent<Renderer>().material = _r;
                GetComponent<TrailRenderer>().material = _r;
                break;
            case 2:
                GetComponent<Renderer>().material = _g;
                GetComponent<TrailRenderer>().material = _g;
                break;
            case 3:
                GetComponent<Renderer>().material = _b;
                GetComponent<TrailRenderer>().material = _b;
                break;
        }
    }
}

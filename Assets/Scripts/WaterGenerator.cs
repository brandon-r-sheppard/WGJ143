using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGenerator : MonoBehaviour
{

    public GameObject waterDroplet;
    public int numOfWaterDroplets;
    IEnumerator DropWater()
    {
        for(int i = 0; i < numOfWaterDroplets; i++)
        {
            GameObject drop = GameObject.Instantiate(waterDroplet);
            float offset = Random.value / 16;
            Vector3 pos = new Vector3(Random.value > 0.5 ? transform.position.x - offset : transform.position.x + offset, transform.position.y, 0);
            drop.transform.position = pos;
            yield return new WaitForSecondsRealtime(0.05f);
        }
    }
    private void Start()
    {
        StartCoroutine(DropWater());
    }
}

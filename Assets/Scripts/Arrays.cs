using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    public GameObject[] objects;
    public Color[] colors;

    void Start()
    {
        objects[0].GetComponent<Renderer>().material.color = colors[0];
        objects[1].GetComponent<Renderer>().material.color = colors[1];
        objects[2].GetComponent<Renderer>().material.color = colors[2];
        objects[3].GetComponent<Renderer>().material.color = colors[3];
    }
}

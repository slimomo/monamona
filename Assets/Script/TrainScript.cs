using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrainScript : MonoBehaviour
{
    public GameObject[] Train;

    void Start()
    {
        MakeObject();
    }
    public void MakeObject()
    {
        int number = Random.Range(0, Train.Length);
        Instantiate(Train[number], transform.position, transform.rotation);
        Debug.Log("生成");
    }
}

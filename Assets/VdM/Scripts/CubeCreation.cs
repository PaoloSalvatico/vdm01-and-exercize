using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreation : MonoBehaviour
{
    public int size;
    public float spacing = 0.8f;
    public GameObject prefab;
    Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i <= size; i++)
        {
            Instantiate(prefab, new Vector3(i, 0, 0), rot);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

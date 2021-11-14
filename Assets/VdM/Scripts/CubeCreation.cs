using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCreation : MonoBehaviour
{
    public int size;
    public float spacing = 0.8f;
    public GameObject prefab;
    private Quaternion rot;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(prefab, new Vector3(0, 0, 0), rot);
        for(int x = 0; x <= size; x += (int) spacing)
        {

            for (int j = 0; j <= size; j += (int) spacing)
            {

                for(int z = 0; z <= size; z += (int) spacing)
                {
                    Instantiate(prefab, new Vector3(x, j, z), rot);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

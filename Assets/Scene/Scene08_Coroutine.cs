using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene08_Coroutine : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject tracingBulletPrefab;

    public float spawnInterval = .3f;
    public int traceEvery = 10;
    bool ooooop;
    int arrrrgh = 0;

    Dictionary<string, int> myDict = new Dictionary<string, int>();

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Cadence());
            MyDict();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            StopCoroutine(Cadence());
            ooooop = false;
        }
    }

    IEnumerator Cadence()
    {
        if (!ooooop)
        {
            ooooop = true;
            while (ooooop)
            {
                yield return new WaitForSeconds(spawnInterval);
                Instantiate(bulletPrefab);
                arrrrgh++;
                if(arrrrgh > 9)
                {
                    Instantiate(tracingBulletPrefab);
                    arrrrgh = 0;
                }
            }
        }
    }

    public void MyDict()
    {
        myDict.Add("lightGrey", 0x999999);
        myDict.Add("darkGrey", 0x333333);
        myDict.Add("white", 0xffffff);
        myDict.Add("black", 0x000000);
        myDict.Add("red", 0xff0000);
        myDict.Add("green", 0x00ff00);
        myDict.Add("blue", 0x0000ff);

        string res = "";

        foreach(var dict in myDict)
        {
            res += $" - {dict.Key} and {dict.Value}";
        }
        Debug.Log(res);
    }
    
}

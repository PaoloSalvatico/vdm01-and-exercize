using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planetcontroller : MonoBehaviour
{
    [SerializeField] Vector3 startSize;
    public Vector3 minSize;
    public float scalingConstant;
    public float speedingScaling;

    public List<GameObject> bigElements;
    public List<GameObject> mediumElements;
    public List<GameObject> smallElements;

    // Temporary
    private void Start()
    {
        StartCoroutine(SmoothScaling());
    }

    public IEnumerator SmoothScaling()
    {
        startSize = gameObject.transform.localScale;

        while(startSize.x > minSize.x)
        {
            yield return new WaitForSeconds(0.05f);
            //yield return new WaitForEndOfFrame();
            startSize = new Vector3(startSize.x, startSize.y, startSize.z) * scalingConstant;
            gameObject.transform.localScale = startSize;

            if (startSize.z <= 8.1f && startSize.z >= 7.8f)
            {
                DestroyElements(bigElements);
            }
            if (startSize.z <= 6.1f && startSize.z >= 5.8f)
            {
                DestroyElements(mediumElements);
            }
            if (startSize.z <= 3.7f && startSize.z >= 3.3f)
            {
                DestroyElements(smallElements);
            }
        }

        gameObject.SetActive(false);
    }

    //public IEnumerator RawStepScaling()
    //{
    //    startSize = gameObject.transform.localScale;
    //    float i = 2f;
    //    float j = 0.95f;

    //    while (startSize.x > minSize.x)
    //    {
    //        yield return new WaitForSeconds(i);
    //        startSize = new Vector3(startSize.x, startSize.y, startSize.z) * j;
    //        gameObject.transform.localScale = startSize;
    //        if(startSize.z <= 8.1f && startSize.z >= 7.8f)
    //        {
    //            DestroyElements(bigElements);
    //        }
    //        if (startSize.z <= 6.1f && startSize.z >= 4.8f)
    //        {
    //            DestroyElements(mediumElements);
    //        }
    //        if (startSize.z <= 3.1f && startSize.z >= 2.8f)
    //        {
    //            DestroyElements(smallElements);
    //        }
    //    }

    //    gameObject.SetActive(false);
    //}

    public void DecreaseResources()
    {
        scalingConstant -= speedingScaling;
    }

    public void DestroyElements(List<GameObject> list)
    {
        foreach(GameObject go in list)
        {
            go.SetActive(false);
        }
    }
}

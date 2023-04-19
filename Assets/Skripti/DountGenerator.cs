using System.Collections;
using UnityEngine;

public class DountGenerator : MonoBehaviour
{
    public GameObject[] DonutPrefabs;
    public float time = 1.0f;
    float minPos, maxPos;
    Transform OvenTransform;
    void Start()
    {
        OvenTransform = GetComponent<Transform>();
    }

    public void CookDonuts(bool state)
    {
        if (state)
            StartCoroutine(Generet());
        else
            StopAllCoroutines();

    }
    IEnumerator Generet()
    {
        while (true)
        {
            minPos = OvenTransform.position.x - 20;
            maxPos = OvenTransform.position.x + 20;
            var num = Random.Range(minPos, maxPos);
            var position = new Vector2(num, OvenTransform.position.y);
            GameObject donut = Instantiate(DonutPrefabs[Random.Range(0, DonutPrefabs.Length)], position, Quaternion.identity, OvenTransform);
            yield return new WaitForSeconds(time);
        }
    }

}

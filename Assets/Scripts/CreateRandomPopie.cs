using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateRandomPopie : MonoBehaviour
{
    public GameObject enemyPre;
    public float numEn;
    public float xMin = 20f;
    public float xMax = 85f;
    public float yMin = 3.5f;
    public float yMax = -4.5f;

    private void Start()
    {
        GameObject newParent = GameObject.Find("3 - ForeGround");

        for (int i = 0; i < numEn; i++)
        {
            Vector3 newPos = new Vector3(Random.Range(xMin, xMax), Random.Range(yMin, yMax), 0);
            GameObject octo = Instantiate(enemyPre, newPos, Quaternion.identity);
            octo.transform.parent = newParent.transform;
        }
    }
}

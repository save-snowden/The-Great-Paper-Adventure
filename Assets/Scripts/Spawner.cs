using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject[] Beasts;
    private BoxCollider2D col;

    float x1, x2;

    private void Awake()
    {
        col = GetComponent<BoxCollider2D>();

        x1 = transform.position.x - col.bounds.size.x / 2f;
        x2 = transform.position.x + col.bounds.size.x / 2f;
    }

    private void Start()
    {
        StartCoroutine(SpawnBeasts(1f));
    }

    IEnumerator SpawnBeasts(float time)
    {
        yield return new WaitForSecondsRealtime (time);
        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);
        Instantiate(Beasts[Random.Range(0, Beasts.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnBeasts(Random.Range(1f, 2f)));

    }
}

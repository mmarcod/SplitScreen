using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BulletScript : MonoBehaviour
{
    private IEnumerator coroutine;

    void Start()
    {
        coroutine = DeathTimer(1.0f);
        StartCoroutine(coroutine);
    }

    private IEnumerator DeathTimer(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(gameObject);
        }
    }
}

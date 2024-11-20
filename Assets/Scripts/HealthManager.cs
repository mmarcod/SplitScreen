using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    public Slider healthBar;
    public int hP;
    public GameObject gameOverPanel;

    private void Start()
    {
        gameOverPanel.SetActive(false);
        healthBar.value = hP;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("bullet"))
        {
            TookDamage();
            Destroy(other);
        }
    }

    public void TookDamage()
    {
        hP -= 1;
        healthBar.value = hP;
        if (hP <= 0)
        {
            gameOverPanel.SetActive(true);
        }
    }
}

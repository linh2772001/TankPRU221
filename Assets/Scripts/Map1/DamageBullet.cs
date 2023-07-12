using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBullet : MonoBehaviour
{
    HealthPlayer healthPlayer;
    public int damage;
    public void Start()
    {
        damage = 2;
        healthPlayer = FindObjectOfType<HealthPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            healthPlayer.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

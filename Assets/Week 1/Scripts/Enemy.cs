using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 100;
    public float speed = 5.0f;
    public int strength = 20;
    public int experienceValue = 50;
    public string state = "chasing";

    public Transform player;

    void Start()
    {
    }

    void Update()
    {
        if (health <= 0)
        {
            Die();
        }
        else if (state == "chasing")
        {
            Chase(player);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Attack()
    {
    }

    void Die()
    {
        Destroy(gameObject);
    }

    public void GainExperience(int amount)
    {
        experienceValue += amount;
    }

    void Chase(Transform player)
    {
        if (player != null)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }

    void MoveTowardsPlayer(Transform player)
    {
    }
}

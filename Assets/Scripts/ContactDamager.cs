using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactDamager : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);    // 무언가에 부딪히면 나 스스로플 파괴

        Life life = other.GetComponent<Life>();

        if (life != null )
        {
            life.amount -= damage;
        }
    }
}

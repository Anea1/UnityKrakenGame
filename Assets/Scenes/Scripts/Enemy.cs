using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void OnTriggerEnter(Collider other)
    {

        Player playerCapsule = other.gameObject.GetComponent<Player>();

        if (playerCapsule != null)
        {
            {

                playerCapsule.HitEnemy();
                Debug.Log("Player killed");
            }
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Сoin : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        other.GetComponent<Player>().CollectCoins();
    }
}

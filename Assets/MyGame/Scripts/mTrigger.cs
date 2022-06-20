using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mTrigger : MonoBehaviour
{

    public GameObject player;
    public GameObject monster;

    private void OnTriggerEnter(Collider player)
    {
        monster.SetActive(true);
    }
}
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    public GameObject monster, counter;
    private bool done;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player") || done) return;
        monster.SetActive(true);
        counter.SetActive(false);
        done = true;
    }
}
using UnityEngine;

public class MonsterTrigger : MonoBehaviour
{
    public GameObject monster, counter, fAmbience, bAmbience;
    private bool done;
    private void OnTriggerEnter(Collider other)
    {
       if (!other.CompareTag("Player") || done) return;
        monster.SetActive(true);
        counter.SetActive(false);
        fAmbience.SetActive(false);
        bAmbience.SetActive(true);
        done = true; 
    }
}
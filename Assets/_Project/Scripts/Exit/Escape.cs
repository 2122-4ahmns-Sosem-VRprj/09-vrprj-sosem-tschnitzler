using UnityEngine;

public class Escape : MonoBehaviour
{
    public GameObject locomotion, txt;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player")) return;
        txt.SetActive(true);
        locomotion.SetActive(false);
    }
}
using UnityEngine;

public class Egg : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Hand")) return;
        FindObjectOfType<EggCounter>().Add();
        gameObject.SetActive(false);
    }
}

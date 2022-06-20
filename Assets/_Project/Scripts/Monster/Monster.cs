using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Monster : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent navMeshAgent;

    private void Start() => navMeshAgent = GetComponent<NavMeshAgent>();
    private void Update() => navMeshAgent.destination = target.position;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

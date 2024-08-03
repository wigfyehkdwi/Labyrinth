using UnityEngine;
using UnityEngine.AI;

public class MoveToGoal : MonoBehaviour
{
    public Transform[] goals;
    private Animator animator;
    private NavMeshAgent agent;
    private int goalIdx = 0;

    void Awake()
    {
        animator = GetComponentInChildren<Animator>();
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goals[0].position;
    }

    private void Update()
    {
        if (agent.hasPath)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);

            if (goalIdx < (goals.Length - 1))
            {
                Destroy(goals[goalIdx].gameObject);
                agent.destination = goals[++goalIdx].position;
            }
        }
    }
}

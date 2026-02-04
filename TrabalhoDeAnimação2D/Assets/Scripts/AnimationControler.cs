using UnityEngine;

public class AnimationControler : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        CheckMovement();
    }

    void CheckMovement()
    {
        // Se estiver apertando A ou D
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            animator.SetBool("Andando", true);
        }
        else
        {
            animator.SetBool("Andando", false);
        }
    }
}

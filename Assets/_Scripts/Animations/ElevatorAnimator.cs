using UnityEngine;

public class ElevatorAnimator : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public bool playOpen = false;
    public static ElevatorAnimator Instance { get; private set; }


   

    public void PlayAnimation()
    {
        animator.SetBool("open", true);
    }

    public void noitaminAyalP()
    {
        animator.SetBool("open", false);
    }

    
}

using UnityEngine;

public class NPCDeath : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem DeathEffect;
    
    [SerializeField]
    private GameObject particleDeath;

    [SerializeField] 
    private LayerMask wallLayer;

    [SerializeField]
    private EnemyDialogue enemyDialogue;

    [Header("AI")]
    [SerializeField]
    private RoamingAI roamingAI;

    [SerializeField]
    private DialogTemplate dialogTemplate;

    [SerializeField]
    private Collider triggerCollider;

    // Update is called once per frame

    private void OnCollisionEnter(Collision collision)
    {
        if ((wallLayer.value & (1 << collision.gameObject.layer)) != 0) {
            Debug.Log("Ouchie, I hit a wall.");
            DeathEffect.Play();
            Destroy(enemyDialogue);
            Destroy(roamingAI);
            Destroy(dialogTemplate);
            Destroy(triggerCollider);
            ContactPoint contact = collision.GetContact(0);
            particleDeath.transform.position = contact.point;
        }
        else { Debug.Log(collision); }
    }
}

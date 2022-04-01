using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorEnabler : MonoBehaviour
{
    public GameObject AnimatedObject;
    private Animator animator;
    // Start is called before the first frame update
    private void Start()
    {
        animator = AnimatedObject.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            animator.enabled = true;
            this.enabled = false;
        }
    }
}

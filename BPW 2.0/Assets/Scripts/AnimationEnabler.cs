using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEnabler : MonoBehaviour
{
    public GameObject Object;
    private Animator Animation;
    public string AnimationString;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Animation = Object.GetComponent<Animator>();
            Animation.Play(AnimationString);
            this.enabled = false;
        }

    }
}

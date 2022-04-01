using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class AutoCutsceneTrigger : MonoBehaviour
{
    public PlayableDirector Cutscene;
    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            Cutscene.enabled = true;
            this.enabled = false;
        }
    }
}

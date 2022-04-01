using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class CutsceneTrigger1 : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject E;
    public PlayableDirector Cutscene;
    public void OnTriggerStay(Collider Player)
    {
        E.SetActive(true);
        if (Player.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey("e"))
            {
                Cutscene.enabled = true;
                this.GetComponent<SphereCollider>().enabled = false;
                E.SetActive(false);
            }
        }
    }
}

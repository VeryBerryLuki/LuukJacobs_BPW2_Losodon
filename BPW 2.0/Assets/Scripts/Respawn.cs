using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    public int SceneToLoad;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneToLoad);
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPos : MonoBehaviour
{
    private GameMaster gm;

    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        transform.position = gm.lastCheckPointPos;
    }

    void OnCollisionEnter(Collision collision)
    {
        if //this IF checks if the player has hit any of the reb boxes, if they do it calls the "ReSpawnPlayer" fuction and that takes care of putting the player at the check point.
            (
                collision.gameObject.CompareTag("SpinningCW") ||
                collision.gameObject.CompareTag("SpinningCCW") ||
                collision.gameObject.CompareTag("UpDown") ||
                collision.gameObject.CompareTag("SideToSide") ||
                collision.gameObject.CompareTag("Static") ||
                collision.gameObject.CompareTag("Hurts")
            )
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}

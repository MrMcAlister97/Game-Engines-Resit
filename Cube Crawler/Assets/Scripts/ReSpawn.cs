using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReSpawn : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Transform respawnPoint;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if //this IF checks if the player has hit any of the reb boxes, if they do it calls the "ReSpawnPlayer" fuction and that takes care of putting the player at the check point.
            (
                collision.gameObject.CompareTag("SpinningCW") ||
                collision.gameObject.CompareTag("SpinningCCW") ||
                collision.gameObject.CompareTag("UpDown") ||
                collision.gameObject.CompareTag("SideToSide") ||
                collision.gameObject.CompareTag("Static")||
                collision.gameObject.CompareTag("Hurts")
            )
        {
            ReSpawnPlayer();
        }
    }

    public void ReSpawnPlayer()
    {
        //Debug.Log("Hit");
        
        //if the player hits something he is teliported to the repsawn point
        player.transform.position = respawnPoint.transform.position;
    }
}

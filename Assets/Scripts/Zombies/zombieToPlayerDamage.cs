using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieToPlayerDamage : MonoBehaviour
{

    private playerHealthController playerHealthController = new playerHealthController();
    public int damageToPlayer = 5;
    public GameObject player;
    public Image bloodImage;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "PLAYER"){
            Debug.Log("Holisss");
            playerHealthController.playerDamage(damageToPlayer, player, bloodImage);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurplePotion : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerPlatformerController player = collision.GetComponent<PlayerPlatformerController>();
        player.Respawn();
    }
}

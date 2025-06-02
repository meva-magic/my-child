using UnityEngine;

public class DamageZone : MonoBehaviour
{
    public GameObject player;              // Игровой персонаж
    public float damagePerSecond = 10f;    // Скорость нанесения урона персонажу
    private bool isInDamageArea = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Игрок вошёл в зону повреждений");
            isInDamageArea = true;
        }
        else if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);     // Удаляем вражеского персонажа при попадании в зону
        }
    }

    void Update()
    {
        if (isInDamageArea && player != null)
        {
            var playerHealth = player.GetComponent<PlayerHealth>();
            if (playerHealth != null)
                playerHealth.TakeDamage(damagePerSecond);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == player)
        {
            Debug.Log("Игрок покинул зону повреждений");
            isInDamageArea = false;
            RestorePlayerHealth();
        }
    }

    void RestorePlayerHealth()
    {
        var playerHealth = player.GetComponent<PlayerHealth>();
        if (playerHealth != null)
            playerHealth.ResetHealth();
    }
}

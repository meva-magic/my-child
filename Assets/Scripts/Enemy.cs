using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    private Transform target;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

    void OnDestroy()
    {
        Debug.Log("Противник уничтожен!");
    }
}

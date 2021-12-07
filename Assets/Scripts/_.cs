using UnityEngine;

public class EnemyProjectile
{
    [SerializeField] private float speed;
    [SerializeField] private float resetTime;
    private float lifetime;

    public void ActivateProjectile()
    {
        lifetime = 0;
    }
    private void Update()
    {
        float movementSpeed = speed * Time.deltaTime;

        lifetime += Time.deltaTime;
        if (lifetime > resetTime) ;


    }
}
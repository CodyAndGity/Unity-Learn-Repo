using UnityEngine;

public class Turret : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 45;
    [SerializeField] float fireRate= 1;
    [SerializeField] Ammo ammo;
    [SerializeField] Transform muzzle;

    float fireTimer = 0;

    void Start()
    {
        fireTimer = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireTimer -= Time.deltaTime;
        if (fireTimer <= 0)
        {
            Instantiate(ammo, muzzle.position, muzzle.rotation);
            fireTimer += fireRate;
        }

        transform.Rotate(Vector3.up * rotationSpeed*Time.deltaTime);
    }
}

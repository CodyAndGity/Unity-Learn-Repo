using UnityEngine;
using UnityEngine.InputSystem;
public class Rocket : MonoBehaviour
{
    [SerializeField] GameObject effect;
    [SerializeField] float speed = 1.0f;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.forward * speed, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        //if (Keyboard.current.spaceKey.isPressed)
        //{

        //}

    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        Instantiate(effect, transform.position, Quaternion.identity);
    }
}

using UnityEngine;

public class Pet : MonoBehaviour
{
    [Header("速度"), Range(0, 1000)]
    public float speed = 100f;

    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("followPoint").transform;
    }

    private void LateUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 posTarget = target.position;
        Vector3 posPet = transform.position;        

        transform.position = Vector3.Lerp(transform.position, posTarget, 0.5f * Time.deltaTime * speed);        
        transform.LookAt(target);
    }
}

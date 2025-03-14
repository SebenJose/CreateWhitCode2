using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereLancer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject spherePrefab;
    [SerializeField] private float force = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            LaunchSphere();
        }
    }

    public void LaunchSphere()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {

            Vector3 launchDirect = (hit.point - transform.position).normalized;

            GameObject sphere = Instantiate(spherePrefab, transform.position, Quaternion.identity);
            Rigidbody rb = sphere.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(launchDirect * force, ForceMode.Impulse);
            }
        }
    }
}

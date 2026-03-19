using UnityEngine;
using UnityEngine.InputSystem;

public class ShootLe : MonoBehaviour
{
    [SerializeField] private Transform shootPos;
    [SerializeField] private GameObject shootVFXPrefad;
    [SerializeField] private GameObject hitVfxprefeb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }
    void shoot()
    {
        RaycastHit hit;

        Debug.DrawRay(shootPos.position, transform.forward * 30, Color.green);

        if(Physics.Raycast(shootPos.position,transform.forward, out hit, 30)) 
        {
            Debug.DrawRay(shootPos.position,transform.forward * hit.distance, Color.red);
            //Debug.Log($"Ray hits: {hit.collider.name}");
            if (Mouse.current.rightButton.wasPressedThisFrame)
            {
                //
                Instantiate(shootVFXPrefad,shootPos.position, Quaternion.identity,transform);
                Instantiate(hitVfxprefeb, hit.point, Quaternion.identity);

                Destroy(shootVFXPrefad, 3.5f);
                Destroy(hitVfxprefeb, 3.5f);
                if (hit.collider.tag == "Enemy")
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();
                    if (enemy != null)
                    {
                        enemy.TakeDamge();
                    }
                }
            }
        }
    }
}

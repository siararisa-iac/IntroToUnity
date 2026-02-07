using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ShootBullet();
        }
    }

    protected void ShootBullet()
    {
        // Spawn a bullet
        // Spawn a copy of the bullet prefab at the position of this gameobject's transform
        // with a default rotation
        Instantiate(bulletPrefab,
            transform.position,
            Quaternion.identity);
    }
}

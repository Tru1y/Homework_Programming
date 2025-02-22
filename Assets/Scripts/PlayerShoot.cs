using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public GameObject preFab2;
    public Transform bulletTrash;
    public Transform bulletSpawn;


    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject Bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity);

            Bullet.transform.SetParent(bulletTrash);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            GameObject Bullet = Instantiate(preFab2, bulletSpawn.position, Quaternion.identity);

            Bullet.transform.SetParent(bulletTrash);
        }
    }
}

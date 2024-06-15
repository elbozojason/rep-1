using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// grenade launcher
public class weaponProjectile : MonoBehaviour
{
    public GameObject bullets;
    public Transform bulletSpawn;
    public float bulletVelocity = 80f;
    public float bulletLifeTime = 10f;
    public float cd = 1f;
    public float firetime = 0f;
    public float delay = 10f;
    public float roundsinlauncher = 6f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time>=firetime){
            if(roundsinlauncher>0){
          if(Input.GetKeyDown(KeyCode.Mouse0)){
            fireWeapon();
            firetime = Time.time+cd;
        }  
        }
        }
        if(Input.GetKeyDown(KeyCode.R)){
            roundsinlauncher = 6;
            firetime = Time.time+cd+cd+cd;
        }
        
        
    }
    private void fireWeapon()
    {
        
        GameObject bullet = Instantiate(bullets,bulletSpawn.position,Quaternion.identity);
        bullet.GetComponent<Rigidbody>().AddForce(bulletSpawn.forward.normalized*bulletVelocity,ForceMode.Impulse); 
        StartCoroutine(destroybullet(bullet,bulletLifeTime));
        roundsinlauncher = roundsinlauncher - 1;
    }
    private IEnumerator destroybullet(GameObject bullets,float delay){
        yield return new WaitForSeconds(delay);
        Destroy(bullets);
    }
}

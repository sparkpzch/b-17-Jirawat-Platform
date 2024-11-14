using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character, IShootable
{
    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform SpawnPoint { get; set; }

    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }
    public void Shoot()
    {

        if (Input.GetButtonDown("Fire1") && (WaitTime >= ReloadTime))
        {
            GameObject obj = Instantiate(Bullet, SpawnPoint.position, Quaternion.identity);
            Banana banana = obj.GetComponent<Banana>();
            banana.Init(30, this);

            WaitTime = 0;
        }
    }
    private void Start()
    {
        Init(50);
        WaitTime = 0.0f;
        ReloadTime = 1.0f;
    }
    void Update()
    {
        Shoot();
    }
    private void FixedUpdate()
    {
        WaitTime += Time.fixedDeltaTime;
    }
}

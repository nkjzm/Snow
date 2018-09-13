﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snow
{
    public class Gun : MonoBehaviour
    {
        [SerializeField]
        Transform InitialShotMarker = null;
        [SerializeField]
        Bullet BulletPrefab = null;
        [SerializeField]
        float ShotPower = 100f;
        void Update()
        {
            // トリガー押されたら
            if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
            {
                Shoot();
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Shoot();
            }
        }

        void Shoot()
        {
            var bullet = Instantiate<Bullet>(
                BulletPrefab,
                InitialShotMarker.position,
                Quaternion.identity
            );
            bullet.Shoot(transform.forward, ShotPower);
        }
    }
}
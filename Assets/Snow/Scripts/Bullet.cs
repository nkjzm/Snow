using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Snow
{
    [RequireComponent(typeof(Rigidbody))]
    [RequireComponent(typeof(SphereCollider))]
    public class Bullet : MonoBehaviour
    {
        [SerializeField]
        float DestroySecond = 3f;
        void Start()
        {
            StartCoroutine(AutoDestroy());
        }

        IEnumerator AutoDestroy()
        {
            yield return new WaitForSeconds(DestroySecond);
            Destroy(gameObject);
        }

        public void Shoot(Vector3 direct, float power = 100f)
        {
            GetComponent<Rigidbody>().AddForce(direct.normalized * power);
        }
        void OnCollisionEnter(Collision other)
        {
            Destroy(gameObject);
        }
    }
}
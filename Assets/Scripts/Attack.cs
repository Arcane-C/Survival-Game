using System.Collections;
using UnityEngine;
//using UnityEngine.Pool;

public class Attack : MonoBehaviour
{
    [SerializeField] private float attackDelay;
    private ObjectPool pool;

    private void Awake()
    {
        pool = FindAnyObjectByType<ObjectPool>();
    }
    private void Start()
    {
        StartCoroutine(AttackEnumerator());
    }

    private IEnumerator AttackEnumerator()
    {
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(attackDelay);
        }
    }

    private void Shoot()
    {
        pool.Request<Bullet>();
    }
}

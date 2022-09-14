using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match : MonoBehaviour
{
    public GameObject enemyObject;//적 오브젝트
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bullet = Instantiate(enemyObject, transform.position, transform.rotation);
        Rigidbody2D rigid_bullet = bullet.GetComponent<Rigidbody2D>();
    }
}

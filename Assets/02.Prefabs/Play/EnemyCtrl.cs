using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour {

    public int hp = 3;
//    public int initHp = 3;

    public Transform tr;
    public GameObject effect;

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("PLAYER"))
        {
            hp--;
            if (hp == 0)
            {
                GameManager.score += 100;
                Instantiate(effect, tr.position, Quaternion.identity);
                Destroy(this.gameObject);
            }
        }
        if (coll.CompareTag("DESTROYER")){
            Destroy(this.gameObject);
        }
    }
}

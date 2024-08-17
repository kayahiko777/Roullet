using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public int hp;
    public int attackPower;

    // Start is called before the first frame update
    void Start()
    {
        //this.hp = hp - attackPower; 
       
        Damage();
        Damage();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Hial(50);
        }
    }

    private void Damage()
    {
        hp -= attackPower;
    }

    private void Hial(int hialPoint)
    {
        hp += hialPoint;
    }
}

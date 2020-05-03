using UnityEngine;
using UnityEngine.UI;
using System;

public class Bat : MonoBehaviour
{
    public int hp; //= 250;
    public int atk= 30;
    public int heal= 10;
    public Text system;
    public Slime slime;

    public void Atk()
    {
        slime.Hurt();
        //return; //slime.hp;
    }

    public int Hurt()
    {
        int HP = hp - slime.atk;
        hp = HP;
        system.text = "Bat - 受到傷害：" + atk + "\n" + "Bat - 血量剩下：" + hp;
        return hp;
    }

    public void Heal()
    {
        int HP = (hp + heal);
        hp = HP;
        system.text = "Bat - 受到治癒：" + heal + "\n" + "Bat - 血量剩下：" + hp;
        return;
    }
}

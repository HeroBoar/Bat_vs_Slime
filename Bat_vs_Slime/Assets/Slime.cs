using UnityEngine;
using UnityEngine.UI;

public class Slime : MonoBehaviour
{
    public int hp; //= 150;
    public int atk = 10;
    public int heal = 30;
    public Text system;
    public Bat bat;

    public void Atk()
    {
        bat.Hurt();
        //return; //bat.hp;
    }

    public int Hurt()
    {
        int HP = hp - bat.atk;
        hp = HP;
        system.text = "Slime - 受到傷害：" + atk + "\n" + "Slime - 血量剩下：" + hp;
        return hp;
    }

    public void Heal()
    {
        int HP = (hp + heal);
        hp = HP;
        system.text = "Slime - 受到治癒：" + heal + "\n" + "Slime - 血量剩下：" + hp;
        return;
    }
}

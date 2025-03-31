using UnityEngine;

public class Vampire : Enemy
{
    public Manager manager;

    public override void Attack()
    {
        manager.info.text = "The vampire attacks. You lose " + damage + "HP and he heals himself 10HP.";
        manager.player.Health -= damage;
        health += 10;
    }


}

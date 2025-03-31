using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _health = 100;
    public float Health
    {
        get { return _health;}
        set { _health = value;}
    }

    public Manager manager;

    public TextMeshProUGUI text;

    public void Attack()
    {
        text.text = "You attack the ennemy. The ennemy loses 30HP.";
        manager.vampire.TakeDamage(30);
        manager.vampire.Attack();
    }

    public void Heal()
    {
        text.text = "You healed yourself and restore 40HP. You have no heal left.";
        Health += 40;
        manager.heal.gameObject.SetActive(false);
        manager.vampire.Attack();
    }


}

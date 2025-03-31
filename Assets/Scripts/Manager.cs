using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Player player;
    public Vampire vampire;
    
    public TextMeshProUGUI info;
    public Button attack;
    public Button heal;

    void Update()
    {
        if (vampire.GetHealth() <= 0)
        {
            info.text = "You won !";
        }
        else if (player.Health <= 0)
        {
            info.text ="You lose";
        }
    }

    void DisableUI()
    {
        attack.gameObject.SetActive(false);
        heal.gameObject.SetActive(false);
    }
}

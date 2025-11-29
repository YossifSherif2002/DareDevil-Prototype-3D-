using UnityEngine;
using UnityEngine.Events;
public class KillCounter : MonoBehaviour
{
    [SerializeField] private int enemies_to_kill;
    [SerializeField] private GameObject win_screen;
    [SerializeField] private UnityEvent OnWinning;
    [SerializeField] private GameObject playerHUD;

    private void Update()
    {
       
        print(enemies_to_kill);
    }



    public void EnemyKilled()
    {
        enemies_to_kill--;
        if (enemies_to_kill <= 0)
        {
            playerHUD.SetActive(false);
            win_screen.SetActive(true);
            OnWinning.Invoke();
        }
    }
}

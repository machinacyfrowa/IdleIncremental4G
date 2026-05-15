using TMPro;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    //pamiêtaj ¿eby przypisaæ te obiekty w edytorze Unity,
    //inaczej bêd¹ nullami i spowoduj¹ b³êdy podczas próby dostêpu do nich
    public GameObject cashCounter;

    int cash = 0;

    void Update()
    {
        cashCounter.GetComponent<TextMeshProUGUI>().text = "Cash: " + cash;
    }
    public void AddCash(int amount)
    {
        cash += amount;
    }
}

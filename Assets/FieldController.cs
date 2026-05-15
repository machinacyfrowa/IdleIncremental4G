using UnityEngine;
using UnityEngine.EventSystems;

public class FieldController : MonoBehaviour, IPointerClickHandler
{
    //referencja do LevelManagera, który bêdzie zarz¹dza³ logik¹ gry,
    //np. dodawaniem gotówki po klikniêciu na pole
    LevelManager levelManager;
   
    void Start()
    {
        //znajdz obiekt o nazwie "LevelManager" w scenie
        //i pobierz jego komponent LevelManager,
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        //sprawdz wszystkie obiekty potomne i dla tych które maja skrypt CropController, wywo³aj metodê Harvest
        foreach(Transform child in transform)
        {
            CropController crop = child.GetComponent<CropController>();
            if(crop != null)
            {
                if(crop.Harvest())
                {
                    //jeœli zbieranie by³o udane, dodaj 10 do gotówki w LevelManagerze
                    levelManager.AddCash(10);
                }
            }
        }
    }
}

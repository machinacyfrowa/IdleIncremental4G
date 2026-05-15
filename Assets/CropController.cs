using UnityEngine;

public class CropController : MonoBehaviour
{
    //odwolanie do obiektu zawieraj¹cego model
    GameObject model; //bêdziemy go skalowaæ
    //stan wzrostu roœliny jako float <0,1> - 1 oznacza pe³ny wzrost
    float growth = 0;
    void Start()
    {   
        //zapisz referencje do pierwszego znalezionego obiektu potomnego
        model = transform.GetChild(0).gameObject;
        model.transform.localScale = Vector3.zero; //ustaw skalê na 0, ¿eby nie by³o widoczne
    }

    // Update is called once per frame
    void Update()
    {
        if(growth < 1) //jeœli roœlina nie jest w pe³ni wyroœniêta
        {
            growth += Time.deltaTime * 0.1f; //zwiêkszaj wzrost o 0.1 na sekundê
            model.transform.localScale = Vector3.one * growth; //skaluj model proporcjonalnie do wzrostu
        }
    }
    public bool Harvest()
    {
        if(growth >= 1) //jeœli roœlina jest w pe³ni wyroœniêta
        {
            growth = 0; //zresetuj wzrost
            model.transform.localScale = Vector3.zero; //ukryj model
            return true; //zbieranie udane
        }
        return false; //zbieranie nieudane, roœlina jeszcze nie dojrza³a
    }
}

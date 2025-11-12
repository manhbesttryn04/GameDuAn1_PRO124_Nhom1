using UnityEngine;
using UnityEngine.EventSystems;


public class ItemBoxColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ public Color Color;
    private void Start()
    {
        Color = gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
       gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = Color.darkRed;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
     gameObject.transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = Color;
    }
   
}

using UnityEngine;
using UnityEngine.EventSystems;


public class ButtonColor : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler

{

    public GameObject buttonText;



    public void OnPointerEnter(PointerEventData eventData)
    {
       buttonText.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().color = Color.gray;
        Transform left = buttonText.transform.Find("Bracket/Left");
        Transform right = buttonText.transform.Find("Bracket/Right");
        if (left != null && right != null)
        {
            left.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
            right.GetComponent<UnityEngine.UI.Image>().color = Color.gray;
        }
    }
    public void OnPointerExit(PointerEventData eventData)
    {
       buttonText.transform.GetChild(0).GetComponent<UnityEngine.UI.Text>().color = Color.white;
        Transform left = buttonText.transform.Find("Bracket/Left");
        Transform right = buttonText.transform.Find("Bracket/Right");
        if (left != null && right != null)
        {
            left.GetComponent<UnityEngine.UI.Image>().color = Color.white;
            right.GetComponent<UnityEngine.UI.Image>().color = Color.white;
        }
    }






}

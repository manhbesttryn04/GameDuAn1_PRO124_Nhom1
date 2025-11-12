using Unity.Properties;
using UnityEngine;

public class ControllerKey : MonoBehaviour
{ public Mission Mission;
   public Bag Bag;
   public  GameObject Key;
    public int clickCout = 0;
    public Color color;
    private void Start()
    {
        color = Bag.GetSlot()[0].transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color;
    }

    private void Update()
    {
        if(clickCout == 1)
        {
           Key.SetActive(true);
           Bag.GetSlot()[0].transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = Color.darkRed;
        }
        else if(clickCout == 2 || clickCout == 0)
        {
            Key.SetActive(false);
            Bag.GetSlot()[0].transform.GetChild(0).GetComponent<UnityEngine.UI.Image>().color = color;
        }
        if(clickCout > 2)
        {
            clickCout = 1;
        }
    }

    // Update is called once per frame
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Key"))
        {
            Bag.AddItem(collision.gameObject);
            Mission.OnhaveKey();
            collision.gameObject.SetActive(false);
            collision.gameObject.GetComponent<BoxCollider2D>().enabled = false;


        }
    }
    public void OnHandKey()
    {
        clickCout  ++;

    }
}

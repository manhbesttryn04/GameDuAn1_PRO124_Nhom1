using UnityEngine;

public class Bag : MonoBehaviour
{
    public GameObject[] slots;
    public GameObject[] items;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        UpdateItems();
    }

    public void AddItem(GameObject item)
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                UpdateItems();
                return;
            }
        }
    }
    public void UpdateItems()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (items[i] != null)
            {
                slots[i].SetActive(true);
                slots[i].transform.GetChild(3).GetComponent<UnityEngine.UI.Image>().sprite = items[i].gameObject.GetComponent<Key>().Geticon();
            }
            else
            {
                slots[i].SetActive(false);
                
            }
        }
    }
    public GameObject[] GetSlot()
    {
        return slots;
    }

}

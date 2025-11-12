using System.Collections;
using TMPro;
using UnityEngine;

public class Mission : MonoBehaviour
{[Header("References")]
    [SerializeField] public GameObject player;
    [SerializeField] public GameObject talkPlayerCanvas;
    [SerializeField] public GameObject talkNPCCanvas;
    [SerializeField] public GameObject talk1;
    [SerializeField] public GameObject talk2;
    [SerializeField ] public GameObject talk3;
    [SerializeField] public GameObject missionCanvas;
   [Header("Status")]
    public bool onTalk1 = true;
    public bool onTalk2 = false;
    public bool skipTalk = true;
    [SerializeField]public SpriteRenderer spriteRenderer;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        spriteRenderer.flipX = transform.position.x < player.transform.position.x;

        if (Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z)) <= 10f)
        {if(skipTalk)
            {
                talkPlayerCanvas.SetActive(true);
                talkNPCCanvas.SetActive(true);

            }
            else
            {
                                talkPlayerCanvas.SetActive(false);
                talkNPCCanvas.SetActive(false);
            }
     
          if(onTalk1)
            {
                talk1.SetActive(true);
            }
            else
            {
                talk1.SetActive(false);
            }
          if(onTalk2)
            {
                talk2.SetActive(true);
            }
            else
            {
                talk2.SetActive(false);
            }
          if(skipTalk == false&& onTalk1 == false&& onTalk2 == false && missionCanvas.activeSelf) { 
                Color c = spriteRenderer.color;
                c.a -= Time.deltaTime;
                spriteRenderer.color = c;
            }


        } else if(Vector2.Distance(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z)) > 10f)
        { 
            talkPlayerCanvas.SetActive(false);
            talkNPCCanvas.SetActive(false);
            if(missionCanvas.activeSelf)
            {
                onTalk1 = false;
                onTalk2 = false;
                skipTalk = false;
            }else             {
                onTalk1 = true;
                skipTalk = true;
            }
           
    } }
    public void OnhaveKey()
    {
        missionCanvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Chìa khóa: 1/1\r\n---------------------------------------------";
    }
    public void OnOpenClose()
    {
        missionCanvas.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Mở cánh cửa: 1/1\r\n\r\n\r\n MISSION COMPLE";
    }
    public  void SkipTalk1()
    {
        onTalk1 = false;
        onTalk2 = true;

    }
    public void SkipTalk2()
    {
        onTalk2 = false;
        missionCanvas.SetActive(true);
       skipTalk = false;
     
    }
    public void CloseMission()
    {
        onTalk1 = false;
        onTalk2 = false;
        talk3.SetActive(true);
        StartCoroutine(CloseTalk());

    }
    public IEnumerator CloseTalk()
    {if(talk3.activeSelf){
            yield return new WaitForSeconds(3f);
            skipTalk = false;
            talk3.SetActive(false);
        }
            

    }
}

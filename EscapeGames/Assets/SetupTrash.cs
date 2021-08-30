using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetupTrash : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject Player;
    public Sprite[] Trashes;

    public GameObject Trash;
    public PolygonCollider2D C_Trash;

    //private bool used = false;//使用済みフラグ(trueでアイテム使用済み)

    void Start() {
        Player = InheritPlayer.Instance;
        Setup();
    }
    // Update is called once per frame
    void Update()
    {
        //if(used==true){
            //Player.GetComponent<GameDataCollection>().eventFlagList[(int)itemList.Film1] = status.final;
        //}
    }
    public void Setup(){
        if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)itemList.Film1] == status.initial){
            Trash.GetComponent<SpriteRenderer>().sprite = Trashes[0]; 
            //フィルム1取得できるのでtrue
            C_Trash.enabled = true;
            //used = true;
        }else if(Player.GetComponent<GameDataCollection>().eventFlagList[(int)itemList.Film1] == status.final){
            Trash.GetComponent<SpriteRenderer>().sprite = Trashes[1]; 
            //フィルム1取得済みなのでfalse
            C_Trash.enabled = false;
        }
    }

    //public void changeSprite(){
        //this.gameObject.GetComponent<SpriteRenderer>().sprite = Trashes[1];
    //}
}

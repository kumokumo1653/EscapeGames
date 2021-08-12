using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreateSlotScript : MonoBehaviour
{
    /*// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/

    //　アイテム情報のスロットプレハブ
    [SerializeField]
    private GameObject slot;
    //　主人公のステータス
    [SerializeField]
    private MyStatus myStatus;
    //　アイテムデータベース
    [SerializeField]
    private ItemDataBase itemDataBase;
 
    //　アクティブになった時
    void OnEnable() {
        //　アイテムデータベースに登録されているアイテム用のスロットを全作成
        CreateSlot(itemDataBase.GetItemDataList());
    }
 
    //　アイテムスロットの作成
    public void CreateSlot(List<ItemListController> itemList) {
 
        int i = 0;
 
        foreach (var item in itemList) {
            if (myStatus.GetItemFlag(item.GetItemName())) {
                //　スロットのインスタンス化
                var instanceSlot = Instantiate<GameObject>(slot, transform);
                //　スロットゲームオブジェクトの名前を設定
                instanceSlot.name = "ItemSlot" + i++;
                //　Scaleを設定しないと0になるので設定
                instanceSlot.transform.localScale = new Vector3(1f, 1f, 1f);
                //　アイテム情報をスロットのProcessingSlotに設定する
                instanceSlot.GetComponent<ProcessingSlot>().SetItemData(item);
            }
        }
    }

}
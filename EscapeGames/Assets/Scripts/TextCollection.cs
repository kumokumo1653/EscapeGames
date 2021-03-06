using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum TextList{
    sample, // デバッグ
    cube,   // デバッグ
    circle, // デバッグ
    start,
    hero1, //主人公(「」で囲まれた文章は全て主人公)
    hero2, 
    hero3, 
    hero4,
    hero5,
    hero6,
    hero7,
    hero8,
    hero9,
    end,
    checkKey,//共通
    getKeydoor,//画面1 ↓
    openDoor,
    checkPrinter,//画面2 ↓
    setInk,
    openBox,
    getKeyUnderShelf,
    getPrintingPaper,
    getBook,//画面3 ↓
    getInk,
    getScissors,
    getCord,
    getUSB,
    checkPC,
    checkCord,//画面4 ↓
    connectCord,
    checkScreen1,//初期(スクリーンがおろされていない状態)
    checkScreen2,//スクリーンがおろされている状態
    getRod,
    getFilm1,//画面5 ↓
    getKeyOverShelf,
    hint1,//ヒント↓
    hint2,
    hint2_1,
    hint3,
    hint4,
    hint5,
    cutPaper,
    getfilm2,
    LIST_LEN　//enumの長さを取得
}
public static class TextCollection 
{
    public static readonly string[] TextList = new string[]{
        "サンプルテキストです(テスト用)", // デバッグ
        "Cubeです(テスト用)",            // デバッグ
        "Circleです(テスト用)",          // デバッグ
        "PM 17:00",
        "[高専生J]「ん...？ここはどこだ...?」",
        "[高専生J]「確かさっきまで教室で友達とおしゃべりしながらレポートを書いていたはず...」",
        "[高専生J]「明日提出のレポート、まだ半分しか終わってないのに。。」",
        "[高専生J]「やばいよやばい。ここはどこなのか急いで調べなきゃ！」",
        "[高専生J]「ドアが開いた！！これで出られる！！」",
        "気になる場所をマウスでクリックして部屋から脱出しよう!",
        "左右の矢印をクリックすると部屋を移動できるぞ!",
        "右のアイテムをクリックしてから別の場所をクリックするとアイテムを使うことができる!",
        "アイテム同士を組み合わせることもできるから､いろんな場所をクリックしてみよう｡",
        "Thank you for playing!!",
        "鍵がかかっている",//共通
        "ドアの鍵を手に入れた。少し錆びている。",//画面1
        "ガチャリと音がした",
        "ひとつインクが欠けている",//画面2
        "インクをセットした。しかし なにもおこらなかった。",
        "ボックスが開いた音がした",
        "棚の下段の鍵を手に入れた。水に浸かっていたからか、ぬめりがあるため鳥肌が立つ。",
        "印刷した紙を手に入れた。印刷直後の紙は温かい。",
        "本を手に入れた。年季の入った本だ。",//画面3
        "インクを手に入れた。新品のインクは匂いが少しきつい。",
        "ハサミを手に入れた。使い古されていて少し錆びている。",
        "延長コードを手に入れた。J科では授業で欠かせない必須アイテムだ。。",
        "USBを手に入れた。使った形跡がある。何かデータが入っているかも。",
        "デバイスが接続できるようになっている",
        "コードが途切れている",//画面4
        "延長コードをつないだ。プロジェクターに電源が入った。",
        "スクリーン。使えそう。",
        "ちょっとした隙間がある。",
        "長い棒。先端が曲がっている。",
        "フィルムを手に入れた。しましまが気になる。",//画面5
        "棚の上段の鍵を手に入れた。",
        "ドアの鍵とスクリーンに関係が...",//画面1について//ヒント ↓
        "本棚とホワイトボードをよく見ると...",//画面2について 
        "インクを使える機器があれば...",
        "ハサミで切れるものはないか...",//画面3について
        "スクリーンに何かをかざすと...",//画面4について
        "水道に水が溜まっている....不気味だ。",//画面5について
        "ハサミを使って紙を切ってみた。",
        "フィルムを手に入れた。しましまが気になる。"
        
    };
}

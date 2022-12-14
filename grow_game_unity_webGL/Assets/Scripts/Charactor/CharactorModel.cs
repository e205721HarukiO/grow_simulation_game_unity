using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;

public class CharactorModel : MonoBehaviour
{
    public int love = 0; // 愛情度
    public int needLove = 0; // 進化に必要な愛情度
    int numEvolution = 0; // 進化回数
    public CharactorView charactorView;
    public Texture[] images;

    void Start()
    {
        // 初期値が未定の場合、とりあえず代入
        if(needLove == 0){
            love = 0;
            needLove = 2;
        }
    }

    public void feed(){
        // 餌を与え、愛情度を+1する.
        addLove(1);
    }

    void addLove(int n){
        love += n;
    }

    public async UniTask evolution(){
        // キャラクタの進化処理.
        numEvolution++;
        charactorView.evolutionView(images[numEvolution]);
    }

    public bool checkLove(){
        return (love >= needLove);
    }

    public void resetLove(){
        // Loveのリセットを行う.
        love = 0;
    }

}

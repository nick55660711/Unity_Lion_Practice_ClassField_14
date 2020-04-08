using UnityEngine;

public class EnemyManager : MonoBehaviour
{

    [Header("Enemy1")]
    public Enemy Enemy1;
    [Header("Enemy2")]
    public Enemy Enemy2;

    private void Start()
    {

        print("怪物一號的魔力" + Enemy1.魔力); print("怪物二號的裝備" + Enemy2.裝備名稱);


        Enemy1.血量 = 100;
        Enemy2.血量 = 300;
        Enemy1.防禦力 = 50;
        Enemy1.武器名稱 = "木棍";
        Enemy2.武器名稱 = "短刀";
        Enemy1.是否帶有鑰匙 = true;
        Enemy2.是否掉落寶物 = true;


        //-修改怪物一號的血量為 100
        //- 修改怪物二號的血量為 300
        //- 修改怪物一號的防禦力為 50
        // - 修改怪物一號的武器名稱為 ”木棍”
        //-修改怪物二號的武器名稱為 "短刀”
        //- 修改怪物一號的是否帶有鑰匙為 是
        //- 修改怪物二號的是否帶有寶物為 是


    }



}

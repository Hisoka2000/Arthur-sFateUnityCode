var otherpref: GameObject;
var backupPref: GameObject;
var MovePrefabThisMuch: Number;
var Bat: GameObject;
var lifetime = 2.0f;
var flyingBat: GameObject;
var Obstacle: GameObject;
var Prefab4: GameObject;

function Update ()
{
    var CloneObj:GameObject = GameObject.Find("ShadowBatDyes2(Clone)");
    Destroy(CloneObj, lifetime);
}

function OnTriggerEnter2D (other: Collider2D){

    var spawnbat: int = Random.Range(0 , 2);
    var spawnflyingbat: int = Random.Range(0 , 2);
    
    if(spawnbat == 0 || spawnflyingbat == 0){
        Bat.SetActive (false);
        Obstacle.SetActive (true);
        flyingBat.SetActive (true);
    }
    if(spawnbat == 1 || spawnflyingbat == 1){
        Bat.SetActive (true);
        flyingBat.SetActive (false);
    }
        
        if (other.tag == "AttackingEmpty")
        return; 
        
        otherpref.transform.position.x = otherpref.transform.position.x + MovePrefabThisMuch;
        otherpref.transform.position.y = 1.029009;
        backupPref.transform.position.x = backupPref.transform.position.x + (MovePrefabThisMuch/2);
        Prefab4.transform.position.x = Prefab4.transform.position.x + (MovePrefabThisMuch/2);
}
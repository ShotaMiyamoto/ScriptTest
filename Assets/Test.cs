using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss{
	private int hp = 100; //体力
	private int power = 25; //攻撃力
	
	//=====================応用課題用=====================
	private int mp = 53; //MP
	//=====================応用課題用（end）=====================

	// 攻撃用の関数
	public void Attack() { 
			Debug.Log( this.power + "のダメージを与えた" );
	}

	// 防御用の関数
	public void Defence(int damage) { 
			Debug.Log( damage+"のダメージを受けた" );
			// 残りhpを減らす
			this.hp -= damage;
	}
	
	//=====================応用課題用=====================
	public void Magic(int mp){

		if(this.mp - mp > 0)
		{
			this.mp -= mp;
			Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
		}else{
			Debug.Log("MPが足りないため魔法が使えない");
		}

	}
	//=====================応用課題用（end）=====================
}

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Bossクラスの変数を宣言してインスタンスを代入する
		Boss lastBoss = new Boss();

		//攻撃用の関数を呼び出す
		lastBoss.Attack();
		//防御用の関数を呼び出す
		lastBoss.Defence(3);

		//=====================基本課題用=====================
		
		int[] array = {2,5,7,9,11}; //配列の初期化

		for(int i = 0; i < array.Length; i++){ //昇順
			Debug.Log(array[i]);
		}

		for(int i = 0; i < array.Length; i++){ //降順
			Debug.Log(array[array.Length - i - 1]);
		}
		//=====================基本課題用(end)=====================


		//=====================応用課題用=====================
		
		//魔法攻撃用の関数を呼び出す
		lastBoss.Magic(5);

		for(int i = 0; i < 10; i++){ //魔法攻撃を10回繰り返す
			lastBoss.Magic(5);
		}
		//=====================応用課題用（end）=====================


	}
}

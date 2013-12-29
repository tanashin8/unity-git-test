using UnityEngine;
using System.Collections;

public class Debri : MonoBehaviour {
	
	// 1秒あたりの回転角度
	public float angle = 30F;
	// 破壊時の得点
	public int score = 10;
	
	// 回転の中心左表
	private Vector3 targetPos;
	
	void Start () {
		// シーン中のEarthオブジェクトへアクセスしてEarthオブジェクトのTransformコンポーネントへ アクセスする
		Transform target = GameObject.Find("Earth").transform;
		// Earthオブジェクトの位置情報を取得しておく
		targetPos = target.position;
		// 宇宙ゴミの正面の向きをEarthの方向に向ける
		transform.LookAt(target);
		// 宇宙ゴミを0から360の範囲でZ軸を中心に回転させておく
		transform.Rotate(new Vector3(0, 0, Random.Range(0, 360)), Space.World);

		Debug.Log ("Hello GitHub!");
	}
	
	void Update () {
		// Earthを中心に宇宙ゴミの現在の上方向に 毎秒angle分だけ回転する
		Vector3 axis = transform.TransformDirection(Vector3.up);
		transform.RotateAround(targetPos, axis, angle * Time.deltaTime);
	}
	
	void OnMouseDown() {
		// クリックされたら宇宙ゴミを消す
		Destroy(gameObject);
	}
}

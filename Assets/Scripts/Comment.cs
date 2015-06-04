using UnityEngine;
using System.Collections;
using NCMB;
using System.Collections.Generic;

public class Comment : MonoBehaviour {

	public int    wave   { get; private set; }
	public string text   { get; set; }
	public string player { get; private set; }
	
	// コンストラクタ -----------------------------------
	
	public Comment(int _wave, string _text, string _player)
	{
		wave   = _wave;
		text   = _text;
		player = _player;
	}
	
	// サーバーにコメントを保存 -------------------------
	
	public void save()
	{
		// Commentクラスのオブジェクトをつくる
		NCMBObject obj = new NCMBObject ("Comment");
		// フィールドを設定して保存
		obj["Wave"]   = wave;
		obj["Text"]   = text;
		obj["Player"] = player;
		obj.SaveAsync ();
	}
}

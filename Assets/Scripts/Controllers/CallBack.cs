
/**
 * 
 * 			D:全局回调类
 * 
 * 
 * 
 * */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CallBack
{
	public delegate void DefaultCallBack();

	public delegate void ResposeCallBack(object value);

	public delegate void ResposesCallBack(string[] value);
}

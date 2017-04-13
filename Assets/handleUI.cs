using UnityEngine;
using System;
using System.Collections;

public class handleUI : MonoBehaviour {

//	private Canvas mTargetBuilderCanvas;
//	private MenuAnimator mMenuAnim;
//	private bool mVuforiaStarted = false;

	public GameObject mProductInfo;
	public GameObject mProductInfoMayo;
	public GameObject imageTargetNike;
	public	GameObject imageTargetMayo;
	// Use this for initialization
	void Start () {
		mProductInfo = GameObject.Find("ProductInfoCanvas");
		mProductInfoMayo = GameObject.Find ("ProductInfoCanvas2");
		imageTargetNike = GameObject.Find ("imageTargetNike");
		imageTargetMayo = GameObject.Find ("imageTargetMayo");

//		mMenuAnim = FindObjectOfType<MenuAnimator>();
//		mTargetBuilderCanvas = GetComponentInChildren<Canvas>();
//		mTargetBuilderCanvas.enabled = false;
//		VuforiaARController.Instance.RegisterVuforiaStartedCallback(OnVuforiaStarted);
	}
	
	// Update is called once per frame
	void Update () {
		
//		if (mVuforiaStarted)
//		{
//			// The target builder canvas must be shown only when the menu UI is NOT shown,
//			// and vice versa (so that they do not overlap each other)
//			bool menuShown = mMenuAnim && mMenuAnim.IsVisible();
//			if (mTargetBuilderCanvas.enabled == menuShown)
//				mTargetBuilderCanvas.enabled = !menuShown;
//		}
//		else
//		{
//			if (mTargetBuilderCanvas.enabled)
//				mTargetBuilderCanvas.enabled = false;
//		}
	}


	#region PUBLIC_METHODS
	public void OnInfoPress(){
		Debug.Log ("Pressed");

		if (mProductInfoMayo.active || mProductInfo.active) {
			mProductInfoMayo.SetActive (false);
			mProductInfo.SetActive (false);
		} else if (!mProductInfoMayo.active || !mProductInfo.active) {
			mProductInfoMayo.SetActive (true) ;
			mProductInfo.SetActive (true);
		}
		

	

	}
	
	#endregion
}

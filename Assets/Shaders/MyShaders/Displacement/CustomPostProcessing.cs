﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CustomPostProcessing : MonoBehaviour {

	public Material EffectMaterial;

	void OnRenderImage( RenderTexture src, RenderTexture dst )
	{
		Graphics.Blit(src, dst, EffectMaterial);
	}

}

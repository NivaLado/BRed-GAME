Shader "Shaders101/PostProcessing"
{
	Properties
	{
		_MainTex("Texture", 2D) = "white" {}
		_DisplaceTex("Texture", 2D) = "white" {}
		_Magnitude("Magnitude", Range(0,0.1)) = 1
	}

	SubShader
	{
		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			//Information from each vertex from the mesh
			struct appdata 
			{
				float4 vertex : POSITION;
				float2 uv : TEXCOORD0;
			};

			//Information that we are passing to the fragment shader
			struct v2f
			{
				float4 vertex : SV_POSITION;
				float2 uv : TEXCOORD0;
			};


			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.uv = v.uv;	 
				return o;
			};

			sampler2D _MainTex;
			sampler2D _DisplaceTex;
			float _Magnitude;

			float4 frag(v2f i) : SV_TARGET
			{
				float2 distuv = float2(i.uv.x + _Time.x * (-2 * cos(_Time.x * 2)), i.uv.y + _Time.x * (-2 * sin(_Time.x * 2) ));

				float2 disp = tex2D(_DisplaceTex, distuv).xy;
				disp = (( disp * 2 ) -1) * _Magnitude ;//* sin(_Time.x * 10);

				float4 col = tex2D(_MainTex, i.uv + disp);
				return col;
			};
			ENDCG
		}
	}
}
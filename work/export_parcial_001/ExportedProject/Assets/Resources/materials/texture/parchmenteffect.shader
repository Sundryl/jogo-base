Shader "Custom/ParchmentEffect" {
	Properties {
		_MainTex ("Texture", 2D) = "white" {}
		_ParchmentTex ("Parchment Texture", 2D) = "white" {}
		_ParchmentColor ("Parchment Color", Vector) = (1,1,1,1)
		_ParchmentStrength ("Parchment Strength", Range(0, 1)) = 0.5
		_CameraSize ("Camera Size", Float) = 50
		_Brightness ("Brightness", Float) = 1
		_Saturation ("Saturation", Float) = 1
		_ParchmentAspectRatio ("Parchment Aspect Ratio", Float) = 1
		_TilingX ("TilingX", Float) = 1
		_TilingY ("TilingY", Float) = 1
		[Toggle] _UseGreyscale ("Use Greyscale", Float) = 0
		_Aspect ("Aspect", Float) = 50
		_CameraPosition ("Camera Position", Vector) = (0,0,0,0)
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;
			float4 _MainTex_ST;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
				float2 uv : TEXCOORD0;
			};

			struct Vertex_Stage_Output
			{
				float2 uv : TEXCOORD0;
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.uv = (input.uv.xy * _MainTex_ST.xy) + _MainTex_ST.zw;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			Texture2D<float4> _MainTex;
			SamplerState sampler_MainTex;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy);
			}

			ENDHLSL
		}
	}
	Fallback "Diffuse"
}
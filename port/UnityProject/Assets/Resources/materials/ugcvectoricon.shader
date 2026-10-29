Shader "UGC/VectorIcon" {
	Properties {
		_PartColor0 ("Part Color 0", Vector) = (1,1,1,1)
		_PartColor1 ("Part Color 1", Vector) = (1,1,1,1)
		_PartColor2 ("Part Color 2", Vector) = (1,1,1,1)
		_PartEnable ("Part Enable", Vector) = (1,0,0,0)
		_AAWidth ("AA Width", Range(0.5, 2)) = 1
		_EdgeMin ("Edge Min", Range(0, 1)) = 0.35
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return float4(1.0, 1.0, 1.0, 1.0); // RGBA
			}

			ENDHLSL
		}
	}
}
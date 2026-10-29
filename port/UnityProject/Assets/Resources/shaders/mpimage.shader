Shader "MPUI/Procedural Image" {
	Properties {
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Vector) = (1,1,1,1)
		_TextureSize ("Texture Size", Vector) = (1,1,1,1)
		_DrawShape ("Draw Shape", Float) = 2
		_StrokeWidth ("Stroke Width", Float) = 0
		_FalloffDistance ("Falloff Distance", Float) = 0.5
		_PixelWorldScale ("Pixel world scale", Range(0.01, 5)) = 1
		_ShapeRotation ("shape Rotation", Float) = 0
		_ConstrainRotation ("Constrained Rotation", Float) = 0
		_FlipHorizontal ("Flip Horizontal", Float) = 0
		_FlipVertical ("Flip Vertical", Float) = 0
		_RectangleCornerRadius ("Rectangle Corner Radius", Vector) = (0,0,0,0)
		_CircleRadius ("Circle Radius", Float) = 0
		_CircleFitRadius ("Fit Circle Radius", Float) = 0
		_PentagonCornerRadius ("Pentagon Corner Radius", Vector) = (0,0,0,0)
		_PentagonTipRadius ("Pentagon Triangle Radius", Float) = 0
		_PentagonTipSize ("Pentagon Triangle Size", Float) = 0
		_TriangleCornerRadius ("Triangle Radius", Vector) = (0,0,0,0)
		_HexagonTipSize ("Hexagon Tip Size", Vector) = (0,0,0,0)
		_HexagonTipRadius ("Hexagon Tip Radius", Vector) = (0,0,0,0)
		_HexagonCornerRadius ("Hexagon Corner Radius", Vector) = (0,0,0,0)
		_NStarPolygonSideCount ("NStar Polygon Side Count", Float) = 3
		_NStarPolygonInset ("Nstar Polygon Inset", Float) = 2
		_NStarPolygonCornerRadius ("Nstar Polygon Corner Radius", Float) = 0
		_NStarPolygonOffset ("Nstar Polygon Offset", Vector) = (0,0,0,0)
		_EnableGradient ("Enable GradientEffect", Float) = 0
		_GradientType ("GradientEffect Type", Float) = 0
		_GradientInterpolationType ("GradientEffect Interpolation Type", Float) = 0
		_GradientRotation ("_GradientRotation", Float) = 0
		_GradientColor0 ("GradientColor0", Vector) = (0,0,0,0)
		_GradientColor1 ("GradientColor1", Vector) = (1,1,1,1)
		_GradientColor2 ("GradientColor2", Vector) = (0,0,0,0)
		_GradientColor3 ("GradientColor3", Vector) = (0,0,0,0)
		_GradientColor4 ("GradientColor4", Vector) = (0,0,0,0)
		_GradientColor5 ("GradientColor5", Vector) = (0,0,0,0)
		_GradientColor6 ("GradientColor6", Vector) = (0,0,0,0)
		_GradientColor7 ("GradientColor7", Vector) = (0,0,0,0)
		_GradientColorLength ("GradientColorLength", Float) = 0
		_GradientAlpha0 ("GradientAlpha0", Vector) = (1,0,0,0)
		_GradientAlpha1 ("GradientAlpha1", Vector) = (1,1,0,0)
		_GradientAlpha2 ("GradientAlpha2", Vector) = (0,0,0,0)
		_GradientAlpha3 ("GradientAlpha3", Vector) = (0,0,0,0)
		_GradientAlpha4 ("GradientAlpha4", Vector) = (0,0,0,0)
		_GradientAlpha5 ("GradientAlpha5", Vector) = (0,0,0,0)
		_GradientAlpha6 ("GradientAlpha6", Vector) = (0,0,0,0)
		_GradientAlpha7 ("GradientAlpha7", Vector) = (0,0,0,0)
		_GradientAlphaLength ("GradientAlphaLength", Float) = 0
		_CornerGradientColor0 ("CornerGradientColor0", Vector) = (1,0,0,1)
		_CornerGradientColor1 ("CornerGradientColor1", Vector) = (0,1,0,1)
		_CornerGradientColor2 ("CornerGradientColor2", Vector) = (0,0,1,1)
		_CornerGradientColor3 ("CornerGradientColor3", Vector) = (0,0,0,1)
		_OutlineWidth ("Outline Width", Float) = 0
		_OutlineColor ("Outline Color", Vector) = (0,0,0,1)
		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
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
			float4 _Color;

			struct Fragment_Stage_Input
			{
				float2 uv : TEXCOORD0;
			};

			float4 frag(Fragment_Stage_Input input) : SV_TARGET
			{
				return _MainTex.Sample(sampler_MainTex, input.uv.xy) * _Color;
			}

			ENDHLSL
		}
	}
	//CustomEditor "MPUIKIT.Editor.MPImageShaderGUI"
}
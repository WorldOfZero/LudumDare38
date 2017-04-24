Shader "Custom/MaskedShader" {
	Properties{
		_Mask("Mask", 2D) = "white" {}
		_World1("World 1 (RGB)", 2D) = "white" {}
		_World2("World 2 (RGB)", 2D) = "white" {}
	}
		SubShader{
		Tags{ "RenderType" = "Opaque" }
		LOD 200

		CGPROGRAM
		// Physically based Standard lighting model, and enable shadows on all light types
#pragma surface surf Standard fullforwardshadows

		// Use shader model 3.0 target, to get nicer looking lighting
#pragma target 3.0

		sampler2D _Mask;
	sampler2D _World1;
	sampler2D _World2;

	struct Input {
		float2 uv_World1;
	};

	half _Glossiness;
	half _Metallic;
	fixed4 _Color;

	void surf(Input IN, inout SurfaceOutputStandard o) {
		fixed4 mask = tex2D(_Mask, IN.uv_World1);
		fixed4 world1Color = tex2D(_World1, IN.uv_World1);
		fixed4 world2Color = tex2D(_World2, IN.uv_World1);
		o.Albedo = (world2Color.rgb * (1 - mask.r)) + (world1Color.rgb * (mask.r));
		o.Emission = o.Albedo;
		// Metallic and smoothness come from slider variables
		o.Metallic = _Metallic;
		o.Smoothness = _Glossiness;
		o.Alpha = 1;
	}
	ENDCG
	}
		FallBack "Diffuse"
}

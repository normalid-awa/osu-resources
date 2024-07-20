////#include "sh_Utils.h"
////#include "sh_Masking.h"

layout(location = 2) in highp vec2 v_TexCoord;

layout(set = 1, binding = 0) uniform lowp texture2D Texture;
layout(set = 1, binding = 1) uniform lowp sampler Sampler;

layout(location = 1) in lowp vec4 v_Colour;


//layout(std140, set = 0, binding = 0) uniform m_ColorblindData
//{
//	mediump int Mode;
//};

layout(location = 0) out vec4 o_Colour;


void main(void)
{
    //lowp vec4 col = getRoundedColor(vec4(1.0), v_TexCoord);
	highp vec4 col = texture(sampler2D(Texture, Sampler), v_TexCoord);

	//highp vec4 px = texture(sampler2D(Texture, Sampler), v_TexCoord);
	//if (Mode == 1) { px = px.gbra; }
	//if (Mode == 2) { px = px.brga; }
	//if (Mode == 3) { px = px.bgra; }
	o_Colour = vec4(1.0,0.0,1.0,1.0);
}

#version 330 core
out vec4 FragColor;

in vec2 TexCoord;

uniform sampler2D texture0;
uniform sampler2D texture1;

in vec3 vertexColor;
uniform bool useUniformColor;
uniform vec4 uniformColor;

void main()
{
    if(useUniformColor) {
        FragColor = mix(texture(texture0, TexCoord), texture(texture1, TexCoord), 0.2) * uniformColor;
    } else {
        // FragColor = vec4(vertexColor, 1.0f);
        FragColor = mix(texture(texture0, TexCoord), texture(texture1, TexCoord), 0.2) * vec4(vertexColor, 1.0f);
    }
}
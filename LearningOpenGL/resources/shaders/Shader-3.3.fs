#version 330 core
out vec4 FragColor;

in vec3 vertexColor;
uniform bool useUniformColor;
uniform vec4 uniformColor;

void main()
{
    if(useUniformColor) {
        FragColor = uniformColor;
    } else {
        FragColor = vec4(vertexColor, 1.0f);
    }
}
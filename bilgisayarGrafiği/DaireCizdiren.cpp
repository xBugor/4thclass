#include <GL/glut.h>
#include <cmath> // veya #include <math.h>

#ifndef M_PI
#define M_PI 3.14159265358979323846
#endif

void drawCircle(float cx, float cy, float r, int num_segments) {
    glBegin(GL_POLYGON);
    for (int i = 0; i < num_segments; i++) {
        float theta = 2.0f * M_PI * float(i) / float(num_segments); // Açı hesaplama
        float x = r * cosf(theta); // X koordinatı
        float y = r * sinf(theta); // Y koordinatı
        glVertex2f(x + cx, y + cy); // Köşe noktası ekleme
    }
    glEnd();
}

void display() {
    glClear(GL_COLOR_BUFFER_BIT);
    glColor3f(1.0f, 0.0f, 0.0f); // Kırmızı renk
    drawCircle(0.0f, 0.0f, 0.5f, 100); // Merkez (0,0), yarıçap 0.5, 100 segment
    glFlush();
}

void init() {
    glClearColor(0.0, 0.0, 0.0, 0.0);
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB);
    glutInitWindowSize(800, 600);
    glutCreateWindow("OpenGL Daire");
    init();
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}
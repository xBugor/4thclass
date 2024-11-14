#include <GL/glut.h>



void display() {
    glClear(GL_COLOR_BUFFER_BIT);

    glBegin(GL_LINES); // Çizgi çizmeye başla
    glVertex2f(-0.5f, 0.0f); // İlk nokta
    glVertex2f(0.5f, 0.0f);  // İkinci nokta
    glEnd(); // Çizimi bitir

    glFlush();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutCreateWindow("OpenGL Çizgi Çizme");
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}
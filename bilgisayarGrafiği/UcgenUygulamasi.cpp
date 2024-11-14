#include <GL/glut.h>



void display() {
    glClear(GL_COLOR_BUFFER_BIT);


    glBegin(GL_POLYGON);      //Poligon çizmeye başla komutu. 
    glVertex2f(0.25, 0.25);     //1. köşenin x ve y bileşenleri 
    glVertex2f(0.75, 0.25);     //2. köşenin x ve y bileşenleri 
    glVertex2f(0.50, 0.75);     //3. köşenin x ve y bileşenleri 
    glEnd();

    glFlush();
}

int main(int argc, char** argv) {
    glutInit(&argc, argv);
    glutCreateWindow("OpenGL Çizgi Çizme");
    glutDisplayFunc(display);
    glutMainLoop();
    return 0;
}
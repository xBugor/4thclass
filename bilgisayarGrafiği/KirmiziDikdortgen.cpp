#include <stdio.h> 
#include <stdlib.h> 
#include <GL/glut.h> 
 
void ayarlar(void){ 
    glClearColor(0.0,0.0,0.0,0.0); 
    glOrtho(-2.0, 2.0, -2.0, 2.0, -1.0, 1.0); //Koordinat sistemini ayarla 
} 
 
void display(void){  
    glClear(GL_COLOR_BUFFER_BIT);         // Renk bufferını  temizle 
    glColor3f(1.0, 0.0, 0.0);               //Renk değeri ata 
    glBegin(GL_POLYGON);                      //Poligon çizmeye başla   
    glVertex2f(-0.5, -0.5);               //Köşe değerleri 
    glVertex2f(-0.5, 0.5); 
    glVertex2f(0.5, 0.5); 
    glVertex2f(0.5, -0.5); 
    glEnd();      //Poligon çizimi bitir 
    glFlush();      //Çizim komutlarını çalıştır 
 } 
 
int main(int argc, char **argv){ 
    glutInit(&argc,argv); 
    glutInitDisplayMode(GLUT_SINGLE | GLUT_RGB ); 
    glutInitWindowPosition(0,0); 
    glutInitWindowSize(500,400); 
    glutCreateWindow("OpenGL Uygulamaları-I"); 
    ayarlar(); 
    glutDisplayFunc(display); 
    glutMainLoop(); 
    return 0; 
} 

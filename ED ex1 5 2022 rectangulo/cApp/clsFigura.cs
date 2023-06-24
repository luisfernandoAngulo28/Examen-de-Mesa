using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsFigura
    {
         /*ATRIBUTOS*/
       
        const int Max=3;                     // Maxima Cantidad de Maxima de filas del Arreglo S
        public int[,] S = new int[Max, 3];   //  S es un arreglo donde se almacena los valores<>0 de una Matriz Esparcida A 
        public int Cant = 0;                 //  Cantidad de celdas con valores<>0 de la Matriz Esparcida A 

        /*CONSTRUCTORES*/
        public clsFigura() 
        { 
            Cant = 0; 
            int i = 0; int j = 0;
            while (i <= Max-1)

            {
                j = 0;
                while (j <= 2)
                {
                    S[i,j]=0;  
                    j++;
                }
                i++;
            }
        }
        
        public clsFigura(clsFigura x)
        {
            Cant = x.Cant;
            int i = 0; int j = 0;
            while (i <= Max - 1)
            {
                j = 0;
                while (j <= 2)
                {
                    S[i, j] = x.S[i,j];
                    i++;
                }
                j++;
            }
        }

        // Funcion que dibuja en una cadena los datos almacenados en un arreglo cualquiera
        public string DibujaArreglo(int[,] A)
        {
            int n = A.GetLength(0);
            int m = A.GetLength(1);             
            string texto = "";
            int i = 0;
            while (i < n)
            {
                int j = 0;
                texto += "\n";
                while (j < m)
                {
                    if (A[i, j] != 0)
                        texto += "[" + A[i, j] + "]";
                    else
                        texto += "[_]";
                    j++;
                }
                i++;
            }
            texto += "\n";
            return texto;
        }

        // Funcion que pasa los valores de la matriz esparcida A a S
        public void PasarAtoS(int[,] A)
        {
            
        }

        // Dibuja en una cadena la figura dentro de las celas de A, para dibujar la figura se debe utilizar los datos del arreglo S
        
        public string DibujarFiguraFronS()
        {
            string str = "";
           
            return str;
        }

        // Funciones para los movimientos de la figura dentro de A utlizando los datos de S
          
        // Funcion que actualiza los datos S para mover la figura hacia arriba
        public void MovUp()
        {
            
        }

        // Funcion que actualiza los datos S para mover la figura hacia abajo
        public void MovDown()
        {
           
        }

        // Funcion que actualiza los datos S para mover la figura hacia la Izquierda
        public void MovIzq()
        {
          
        }

        // Funcion que actualiza los datos S para mover la figura hacia la derecha
        public void MovDer()
        {
            
        }

    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Tec_Lite
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pantalla2.Text = "\r\n Calculator Tec Lite" +
                "\r\n Copyright ©  2022" +
                "\r\n Tamaño de aplicacion: 336 KB" +
                "\r\n Tecnicas de conteo" +
                "\r\n Developer Jhordan Pacheco";
        }

        private double n = 0;
        private double r = 0;
        private double k = 0;
        private double CR;
        private double mult;
        private double total;
        private double total2;
        private double total3;
        private double Resta;
        private double Resultado;
        private string operacion;
        private int i,j,u;

        private void Button5_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "5";
            }
            else
            {
                PantallaCalculadora.Text += "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "6";
            }
            else
            {
                PantallaCalculadora.Text += "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "7";
            }
            else
            {
                PantallaCalculadora.Text += "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "8";
            }
            else
            {
                PantallaCalculadora.Text += "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "9";
            }
            else
            {
                PantallaCalculadora.Text += "9";
            }
        }

        private void ButtonPunto_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = ".";
            }
            else
            {
                PantallaCalculadora.Text += ".";
            }
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(PantallaCalculadora.Text);
            switch (operacion)
            {
                case "*":
                    Resultado = n * r;
                    PantallaProd.Text = n + operacion + r +" = ";
                    break;
                case "+":
                    Resultado = n + r;
                    PantallaProd.Text = n + operacion + r + " = ";
                    break;
                case "-":
                    Resultado = n - r;
                    PantallaProd.Text = n + operacion + r + " = ";
                    break;
                case "/":
                    Resultado = n / r;
                    PantallaProd.Text = n + operacion + r + " = ";
                    break;
                case "^":
                    Resultado = Math.Pow(n, r);
                    PantallaProd.Text = n + operacion + r + " = ";
                    break;
            }
            PantallaCalculadora.Text = Resultado.ToString();
        }

        private void ButtonPor_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                operacion = "*";
                PantallaProd.Text = n + operacion;
            }
            else
            {
                operacion = "*";
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
                PantallaProd.Text = n + operacion;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "4";
            }
            else
            {
                PantallaCalculadora.Text += "4";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "3";
            }
            else
            {
                PantallaCalculadora.Text += "3";
            }
        }

        private void ButtonSuma_Click(object sender, EventArgs e)
        {
            
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                operacion = "+";
                PantallaProd.Text = n + operacion;
            }
            else
            {
                operacion = "+";
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
                PantallaProd.Text = n + operacion;
            }
        }

        private void ButtonResta_Click(object sender, EventArgs e)
        {

            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                operacion = "-";
                PantallaProd.Text = n + operacion;
            }
            else
            {
                operacion = "-";
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
                PantallaProd.Text = n + operacion;
            }
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                operacion = "/";
                PantallaProd.Text = n + operacion;
            }
            else
            {
                operacion = "/";
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
                PantallaProd.Text = n + operacion;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "2";
            }
            else
            {
                PantallaCalculadora.Text += "2";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "1";
            }
            else
            {
                PantallaCalculadora.Text += "1";
            }
        }

        private void ButtonLimpiar_Click(object sender, EventArgs e)
        {
            PantallaCalculadora.Text = "";
            n = 0;
            r = 0;
            k = 0;
            Pantalla2.Text = "";
            PantallaProd.Text = "";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                PantallaCalculadora.Text = "0";
            }
            else
            {
                PantallaCalculadora.Text += "0";
            }
        }

        private void ButtonFactorial_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n P(n) = n! = P(" + n + ") = " + n + "! =";
            total = 1;
            for (i = 1; i <= n; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " = "+ total;
            PantallaCalculadora.Text = total.ToString();
            PantallaProd.Text = "P(n) = n! = P("+n+") = "+n+"! =";
        }

        private void PermutacionCircular_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n Po(n) = (n – 1)! = \r\n Po(" + n +") = (" + n + " -1 )! = ";
            Resta = (n - 1);
            Pantalla2.Text += "\r\n Po(" + n + ") = (" + Resta + ")! = ";
            total = 1;
            for (i = 1; i <= Resta; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Resultado = total;
            PantallaCalculadora.Text = Resultado.ToString();
            Pantalla2.Text += " = " + total;
            PantallaProd.Text = "Po(" + n + ") = (" + n + " -1)! =";
        }

        private void ButtonVariacionSimple_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n V(n,r) = n! / (n-r)! = \r\n V(" + n + "," + r + ") = "+n+"! / ("+n+"-"+r+")! =";
            Pantalla2.Text += "\r\n V(" + n + "," + r + ") = ";
            total = 1;
            for (i = 1; i <= n; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / (";
            Resta = (n - r);
            total2 = 1;
            for (j = 1; j <= Resta; j++)
            {
                total2 *= j;
                Pantalla2.Text += j + "*";
            }
            Resultado = total / total2;
            Pantalla2.Text += ") = ";
            Pantalla2.Text += "\r\n V(" + n + "," + r + ") = " + n + "! / " + Resta + "! = ";
            total3 = 1;
            for (u = (int)(Resta + 1); u <= n; u++)
            {
                total3 *= u;
                Pantalla2.Text += u + "*";
            }
            Pantalla2.Text += " = " + total3;
            PantallaCalculadora.Text = Resultado.ToString();
            PantallaProd.Text = "V(" + n + "," + r + ") = " + n + "! / (" + n + "-" + r + ")! =";
        }

        private void ButtonVariacionRepetida_Click(object sender, EventArgs e)
        {
            Pantalla2.Text += "\r\n V(" + n + "," + k + ") = " + n + "^" + k;
            Resultado = Math.Pow(n, k);
            PantallaCalculadora.Text = Resultado.ToString();
            Pantalla2.Text += " = "+Resultado;
            PantallaProd.Text = "V(" + n + "," + k + ") = " + n + "^" + k+" = ";
        }

        private void ButtonCombinaciones_Click(object sender, EventArgs e)
        {
            PantallaProd.Text = "C(n,r) = n! / ((n-r)! * r!) =";
            Pantalla2.Text = "C(n,r) = n! / ((n-r)!*r!)";
            Pantalla2.Text += "\r\n C("+n+","+r+") = "+n+"! / ("+n+"-"+r+")! * "+r+"! =";
            Resta = n - r;
            Pantalla2.Text += "\r\n C(" + n + "," + r + ") = " + n + "! / (" + Resta + ")! * " + r + "! = ";
            Pantalla2.Text += "\r\n C(" + n + "," + r + ") = ";
            total = 1;
            for (i = 1; i <= n; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / (";
            total2 = 1;
            for (j = 1; j <= Resta; j++)
            {
                total2 *= j;
                Pantalla2.Text += j + "*";
            }
            Pantalla2.Text += ") * (";
            total3 = 1;
            for (u = 1; u <= r; u++)
            {
                total3 *= u;
                Pantalla2.Text += u + "*";
            }
            mult = total2 * total3;
            Resultado = total / mult;
            Pantalla2.Text += ") = ";
            PantallaCalculadora.Text = Resultado.ToString();
            Pantalla2.Text += "\r\n C(" + n + "," + r + ") = ";
            double total4 = 1;
            for (int i = (int)Resta+1; i <= n; i++)
            {
                total4 *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / ";
            total3 = 1;
            for (u = 1; u <= r; u++)
            {
                total3 *= u;
                Pantalla2.Text += u + "*";
            }
            double Resultado2 = total4 / total3;
            Pantalla2.Text += " = "+Resultado2;

        }

        private void ButtonN_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                MessageBox.Show("Error Ingresa un valor");
            }
            else
            {
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
            }
        }

        private void ButtonR_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                MessageBox.Show("Error Ingresa un valor");
            }
            else
            {
                r = Convert.ToDouble(PantallaCalculadora.Text);
            }
        }

        private void ButtonK_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                MessageBox.Show("Error Ingresa un valor");
            }
            else
            {
                k = Convert.ToDouble(PantallaCalculadora.Text);
            }
        }

        private void ButtonPotencia_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "" || PantallaCalculadora.Text == " ")
            {
                operacion = "^";
                PantallaProd.Text = n + operacion;
            }
            else
            {
                operacion = "^";
                n = Convert.ToDouble(PantallaCalculadora.Text);
                PantallaCalculadora.Text = "";
                PantallaProd.Text = n + operacion;
            }
        }

        private void IMGPERSIMPLE_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n P(n) = n!";
            PantallaProd.Text = "P(n) = n! =";
        }

        private void IMGPerCircular_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n Po(n) = (n – 1)!";
            PantallaProd.Text = "Po(n) = (n – 1)! =";
        }

        private void IMGPermuRep_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n P(n,r) = n! / r! ";
            PantallaProd.Text = "P(n,r) = n! / r! =";
        }

        private void VariaSimpleIMG_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n V(n,r) = n! / (n - r)! ";
            PantallaProd.Text = "V(n,r) = n! / (n - r)!";
        }

        private void VariaRepetidaIMG_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n V(n,r,r) = n ^ k";
            PantallaProd.Text = "V(n,r,r) = n ^ k";
        }

        private void CombiRepetidIMG_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n CR(n,k) = (n + k - 1),(k) = ((n + k - 1)! ) / ((n - 1)! * k!)";
            PantallaProd.Text = "CR(n,k) = C((n + k - 1),(k)) =";
        }

        private void CombinIMG_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n C(n,r) = n! / ((n - r)! * r!)";
            PantallaProd.Text = "C(n,r) = n! / ((n - r)! * r!)";
        }

        private void ButtonAyuda_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n INSTRUCCIONES DE USO: \r\n 1. Consulta la Formula en los botones de la Derecha." +
            "\r\n 2. Ingresa las variables ingresando primero el digito, luego precionando los botones sea n, r o k." +
            "\r\n 3. Para finalizar preciona los botones del lado izquierdo con los nombre de las formulas, ejemplo permutacion simple y automaticamente se calcula." +
            "\r\n 4. Para utilizar la calculadora basica, es de la manera tradicional como la conoces, suma, resta, etc." +
            "\r\n 5. Para continuar elimina y repite el proceso." +
            "\r\n 6. Para imprimer el triangulo de pascal, primero ingresa un digito y luego presiona el boton de Triangulo de Pascal";

        }

        private void ButtonPascal_Click(object sender, EventArgs e)
        {
            int[] arreglo = new int[1];
            //mostramo0s un mensaje y capturalos el dato ingresado desde la consol
            int pisos = Convert.ToInt16(PantallaCalculadora.Text);
            if (pisos>=15)
            {
                PantallaCalculadora.Text = "El Triangulo Excede su tamaño a mostrar";
            }
            else
            {
                //declaramos el primer ciclo for que va a rrecorer dependiendo el dato ingresado que esta almacenado ala variable piso
                for (int i = 1; i <= pisos; i++)
                {
                    /* Colocamos un arreglo y colocamos la variable 1 del ciclo for
                     que sera el tamaño que tendra el arreglo cada vez que el ciclo for se ejecute*/
                    int[] pascal = new int[i];
                    for (int j = pisos; j < i; j--)
                    {
                        Pantalla2.Text += " ";
                    }
                    // ciclo for que genera la suma de las cifras
                    for (int k = 0; k < i; k++)
                    {
                        //condicon que evalua la variable del ciclo for
                        if (k == 0 || k == (i - 1))
                        {
                            pascal[k] = 1;
                        }
                        else
                        {
                            // sumamos los numeros qu estan en cada pocion
                            // del arreglo para formar el triangulo
                            pascal[k] = arreglo[k] + arreglo[k - 1];
                        }

                        Pantalla2.Text += "[" + pascal[k] + "]";
                    }
                    arreglo = pascal;
                    Pantalla2.Text += "\r\n";
                }
            }
        }

        private void ButtonNegacion_Click(object sender, EventArgs e)
        {
            if (PantallaCalculadora.Text == "")
            {
                Resultado = -n;
                PantallaProd.Text = "Negacion( " + n + " ) =";
                PantallaCalculadora.Text = Resultado.ToString();
            }
            else
            {
                n = Convert.ToDouble(PantallaCalculadora.Text);
                Resultado = -n;
                PantallaProd.Text = "Negacion( " + n + " ) =";
                PantallaCalculadora.Text = Resultado.ToString();
            }
        }

        private void ButtonCombinacionRepetida_Click(object sender, EventArgs e)
        {
            //CR(n,k) = (n+k-1),(k) = ((n+k-1)!)/((n-1)!*k!)
            Pantalla2.Text = "\r\n CR(n,K) = ((n + k - 1)!) / ((n - 1)! * k!) = \r\n CR(" + n + "," + k + ") = (" + n + " + " + k + " - 1)! / (("+n+" - 1)! * "+k+" ! )";
            
            CR = n + k - 1;
            Resta = n - 1;
            PantallaProd.Text = "CR(" + n + "," + k + ") = (" + n + "+" + k + "-1) , (" + k + ") = C ( "+CR+","+Resta+" ) =";
            Pantalla2.Text += "\r\n CR(" + n + "," + k + ") = C("+CR+","+k+")= "+CR+"! / "+Resta+" ! * "+k+"! =";
            Pantalla2.Text += "\r\n C(" + CR + "," + k + ") = ";
            total = 1;
            for (i = 1; i <= CR; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / ";
            total2 = 1;
            for (j = 1; j <= Resta; j++)
            {
                total2 *= j;
                Pantalla2.Text += j + "*";
            }
            total3 = 1;
            Pantalla2.Text += " * ";
            for (u = 1; u <= k; u++)
            {
                total3 *= u;
                Pantalla2.Text += u + "*";
            }
            Pantalla2.Text += " = ";
            mult = total3 * total2;
            Resultado = total / mult;
            PantallaCalculadora.Text = Resultado.ToString();
            Pantalla2.Text += "\r\n C(" + CR + "," + k + ") = ";
            double total4 = 1;
            for (int i = (int)Resta + 1; i <= CR; i++)
            {
                total4 *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / ";
            double total5 = 1;
            for (j = 1; j <= Resta; j++)
            {
                total5 *= j;
                Pantalla2.Text += j + "*";
            }
            double Resultado2 = total4 / total5;
            Pantalla2.Text += " = "+Resultado2;
        }

        private void PermutaRepetida_Click(object sender, EventArgs e)
        {
            Pantalla2.Text = "\r\n P(n,r) = n! / r! = P(" + n + "," + r + ") = " + n + "! / " + r + "! =";
            PantallaProd.Text = "P(n,r) = n! / r! = P(" + n + "," + r + ") = " + n + "! / " + r + "! =";
            Pantalla2.Text += "\r\n P(" + n + "," + r + ") =";
            total = 1;
            for (i = 1; i <= n; i++)
            {
                total *= i;
                Pantalla2.Text += i + "*";
            }
            Pantalla2.Text += " / ";
            total2 = 1;
            for (j = 1; j <= r; j++)
            {
                total2 *= j;
                Pantalla2.Text += j + "*";
            }
            Pantalla2.Text += " = ";
            Resultado = total / total2;
            PantallaCalculadora.Text = Resultado.ToString();
            Pantalla2.Text += "\r\n P(" + n + "," + r + ") = " + n + "! / " + r + "! = ";
            total3 = 1;
            for (u = (int)(r + 1); u <= n; u++)
            {
                total3 *= u;
                Pantalla2.Text += u + "*";
            }
            Pantalla2.Text += " = " + total3;
        }
    }
}

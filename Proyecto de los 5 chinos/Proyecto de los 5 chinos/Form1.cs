namespace Proyecto_de_los_5_chinos
{
    public partial class Base1 : Form
    {
        //Creacion del semaforo
        static Semaphore Filos = new Semaphore(1, 2);
        static int c1=0;
        static int c2=0;
        static int c3 = 0;
        static int c4=0;    
        static int c5=0;    


        public Base1()
        {
            InitializeComponent();
        }

        private void Iniciar_Click(object sender, EventArgs e)
        {
            cenandoando();

        }

        //creacion de los hilos
        private void cenandoando()
        {
            Thread muertodehambre1 = new Thread(filosofo1);
            Thread muertodehambre2 = new Thread(filosofo2);
            Thread muertodehambre3 = new Thread(filosofo3);
            Thread muertodehambre4 = new Thread(filosofo4);
            Thread muertodehambre5 = new Thread(filosofo5);

            muertodehambre1.Start();
            muertodehambre2.Start();
            muertodehambre3.Start();
            muertodehambre4.Start();
            muertodehambre5.Start();
        }

        //hilo 1
        //Todos los Hilos tienen la misma estructura solo van cambiando los numeros de c, F y P, ademas de los colores de los palillos
        private void filosofo1()
        {
            // cuando el filosofo ya haya comido 5 veces el cuadro a lado de el se pondra negro(lo mismo pasa en los demas hilos)
            Filos.WaitOne();
            if (c1==5)
            {
                
                Invoke(new MethodInvoker(() =>
                {
                    F1.BackColor = Color.Black;

                }));
            }

            else 
            {
                if (P1.BackColor==Color.Navy && P2.BackColor == Color.Navy)
                {
                    // cuando un filosofo agarre un palillo este se iluminara de un color diferente (lo mismo pasa en los demas hilos)
                    Invoke(new MethodInvoker(() =>
                    {
                        P1.BackColor = Color.Red;
                        P2.BackColor = Color.Red;
                         
                    }));
                    c1++;

                    //cuando el filosofo suelte el palillo regresara al color Navy (lo mismo pasa en los demas hilos)
                    //cuando los palillos cambien de color el texto de "comida1" en este caso cambiara y se iniciara un conteo de las veces que esta comiendo el filosofo (lo mismo pasa en los demas hilos)
                    Thread.Sleep(1500);
                    Invoke(new MethodInvoker(() =>
                    {
                        Comida1.Text=c1.ToString();
                        P1.BackColor = Color.Navy;
                        P2.BackColor = Color.Navy;

                    }));
                }
                
            }
            Filos.Release();
        }

        //hilo 2
        private void filosofo2()
        {
            Filos.WaitOne();
            if (c2 == 5)
            {
                
                Invoke(new MethodInvoker(() =>
                {
                    F2.BackColor = Color.Black;

                }));

            }

            else
            {
                if (P2.BackColor == Color.Navy && P3.BackColor == Color.Navy)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        P2.BackColor = Color.SkyBlue;
                        P3.BackColor = Color.SkyBlue;
                        
                    }));
                    c2++;
                    Thread.Sleep(1500);
                    Invoke(new MethodInvoker(() =>
                    {
                        Comida2.Text = c2.ToString();
                        P2.BackColor = Color.Navy;
                        P3.BackColor = Color.Navy;
                    }));
                }

            }
            Filos.Release();
        }

        //hilo 3
        private void filosofo3()
        {
            Filos.WaitOne();
            if (c3 == 5)
            {
                
                Invoke(new MethodInvoker(() =>
                {
                    F3.BackColor = Color.Black;

                }));
            }

            else
            {
                if (P3.BackColor == Color.Navy && P4.BackColor == Color.Navy)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        P3.BackColor = Color.GreenYellow;
                        P4.BackColor = Color.GreenYellow;
                        
                    }));
                    c3++;
                    Thread.Sleep(1500);
                    Invoke(new MethodInvoker(() =>
                    {
                        Comida3.Text = c3.ToString();
                        P3.BackColor = Color.Navy;
                        P4.BackColor = Color.Navy;
                    }));
                }

            }
            Filos.Release();
        }

        //hilo 4
        private void filosofo4()
        {
            Filos.WaitOne();
            if (c4 == 5)
            {
                
                Invoke(new MethodInvoker(() =>
                {
                    F4.BackColor = Color.Black;

                }));
            }

            else
            {
                if (P4.BackColor == Color.Navy && P5.BackColor == Color.Navy)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        P4.BackColor = Color.Yellow;
                        P5.BackColor = Color.Yellow;

                        
                    }));
                    c4++;
                    Thread.Sleep(1500);
                    Invoke(new MethodInvoker(() =>
                    {
                        Comida4.Text = c4.ToString();
                        P4.BackColor = Color.Navy;
                        P5.BackColor = Color.Navy;
                    }));
                }

            }
            Filos.Release();
        }

        //hilo 5
        private void filosofo5()
        {
            Filos.WaitOne();
            if (c5 == 5)
            {
                
                Invoke(new MethodInvoker(() =>
                {
                    F5.BackColor = Color.Black;

                }));
            }

            else
            {
                if (P5.BackColor == Color.Navy && P1.BackColor == Color.Navy)
                {
                    Invoke(new MethodInvoker(() =>
                    {
                        P5.BackColor = Color.Violet;
                        P1.BackColor = Color.Violet;
                    }));
                    c5++;
                    Thread.Sleep(1500);
                    Invoke(new MethodInvoker(() =>
                    {
                        Comida5.Text = c5.ToString();
                        P5.BackColor = Color.Navy;
                        P1.BackColor = Color.Navy;

                    }));
                }

            }
            Filos.Release();
        }
    }
}
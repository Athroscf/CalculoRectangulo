using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace CalculoRectangulo
{
    class Rectangulo : INotifyPropertyChanged
    {
        //Variables Miembro
        public string xPuntoA;
        public string yPuntoA;
        public string xPuntoB;
        public string yPuntoB;
        public string xPuntoC;
        public string yPuntoC;
        public string xPuntoD;
        public string yPuntoD;

        //Propiedades
        public string PuntoXA
        {
            get { return xPuntoA; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) xPuntoA = value;
                OnPropertyChanged("PuntoXA");
            }
        }

        public string PuntoYA
        {
            get { return yPuntoA; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoA = value;
                OnPropertyChanged("PuntoYA");
            }
        }

        public string PuntoXB
        {
            get { return xPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) xPuntoB = value;
                OnPropertyChanged("PuntoXB");
            }
        }

        public string PuntoYB
        {
            get { return yPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoB = value;
                OnPropertyChanged("PuntoYB");
            }
        }

        public string PuntoXC
        {
            get { return yPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoB = value;
                OnPropertyChanged("PuntoXC");
            }
        }

        public string PuntoYC
        {
            get { return yPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoB = value;
                OnPropertyChanged("PuntoYC");
            }
        }

        public string PuntoXD
        {
            get { return yPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoB = value;
                OnPropertyChanged("PuntoXD");
            }
        }

        public string PuntoYD
        {
            get { return yPuntoB; }

            set
            {
                int punto;
                bool resultado = int.TryParse(value, out punto);
                if (resultado) yPuntoB = value;
                OnPropertyChanged("PuntoYD");
            }
        }

        public string Base
        {
            get
            {
                double labase = VerificacionBase();
                return labase.ToString();
            }
            set
            {
                double labase = VerificacionBase();
                labase.ToString();
                OnPropertyChanged("BaseRectangulo");
            }
        }
        
        public string Altura
        {
            get
            {
                double laaltura = VerificacionAltura();
                return laaltura.ToString();
            }
            set
            {
                double laaltura = VerificacionAltura();
                laaltura.ToString();
                OnPropertyChanged("AlturaRectangulo");
            }
        }

        public string Perimetro
        {
            get
            {
                double perimetro;
                perimetro = 2 * double.Parse(Base) + 2 * double.Parse(Altura);
                return perimetro.ToString();
            }
            set
            {
                double perimetro;
                perimetro = 2 * double.Parse(Base) + 2 * double.Parse(Altura);
                perimetro.ToString();
                OnPropertyChanged("Perimetro");
            }
        }
        
        public string Area
        {
            get
            {
                double elarea;
                elarea = double.Parse(Base) * double.Parse(Altura);
                return elarea.ToString();
            }
            set
            {
                double elarea;
                elarea = double.Parse(Base) * double.Parse(Altura);
                elarea.ToString();
                OnPropertyChanged("Area");
            }
        }

        //Metodos

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        private double Distancia(double x1, double x2, double y1, double y2)
        {
            double distancia;
            distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return distancia;
        }

        public double VerificacionBase()
        {
            double base1, base2;
            base1 = Distancia(double.Parse(xPuntoA), double.Parse(xPuntoB), double.Parse(yPuntoA), double.Parse(yPuntoB));
            base2 = Distancia(double.Parse(xPuntoC), double.Parse(xPuntoD), double.Parse(yPuntoC), double.Parse(yPuntoD));
            if (base1 != base2) base1 = 0;
            return base1;
        }
        
        public double VerificacionAltura()
        {
            double altura1, altura2;
            altura1 = Distancia(double.Parse(xPuntoA), double.Parse(xPuntoD), double.Parse(yPuntoA), double.Parse(yPuntoD));
            altura2 = Distancia(double.Parse(xPuntoB), double.Parse(xPuntoC), double.Parse(yPuntoB), double.Parse(yPuntoC));
            if (altura1 != altura2)
            {
                altura1 = 0;

            }
            return altura1;
        }

    }
}

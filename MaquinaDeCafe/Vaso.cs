namespace MaquinaDeCafeApp
{
    public class Vaso
    {
        private int cantidadVasos;
        private int contenido;

        public Vaso(int cantidadVasos, int contenido)
        {
            this.cantidadVasos = cantidadVasos;
            this.contenido = contenido;
        }

        public void setCantidadVasos(int cantidadVasos)
        {
            this.cantidadVasos = cantidadVasos;
        }

        public int getCantidadVasos()
        {
            return cantidadVasos;
        }

        public void setContenido(int contenido)
        {
            this.contenido = contenido;
        }

        public int getContenido()
        {
            return contenido;
        }

        public bool hasVasos(int cantidad)
        {
            return cantidadVasos >= cantidad;
        }

        public void giveVasos(int cantidad)
        {
            if (cantidadVasos >= cantidad)
            {
                cantidadVasos -= cantidad;
            }
        }
    }
} 
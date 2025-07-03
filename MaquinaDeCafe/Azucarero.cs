namespace MaquinaDeCafeApp
{
    public class Azucarero
    {
        private int cantidadDeAzucar;

        public Azucarero(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public void setCantidadDeAzucar(int cantidadDeAzucar)
        {
            this.cantidadDeAzucar = cantidadDeAzucar;
        }

        public int getCantidadDeAzucar()
        {
            return cantidadDeAzucar;
        }

        public bool hasAzucar(int cantidad)
        {
            return cantidadDeAzucar >= cantidad;
        }

        public void giveAzucar(int cantidad)
        {
            if (cantidadDeAzucar >= cantidad)
            {
                cantidadDeAzucar -= cantidad;
            }
        }
    }
} 
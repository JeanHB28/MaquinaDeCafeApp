namespace MaquinaDeCafeApp
{
    public class Cafetera
    {
        private int cantidadCafe;

        public Cafetera(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public void setCantidadDeCafe(int cantidadCafe)
        {
            this.cantidadCafe = cantidadCafe;
        }

        public int getCantidadDeCafe()
        {
            return cantidadCafe;
        }

        public bool hasCafe(int cantidad)
        {
            return cantidadCafe >= cantidad;
        }

        public void giveCafe(int cantidad)
        {
            if (cantidadCafe >= cantidad)
            {
                cantidadCafe -= cantidad;
            }
        }
    }
} 
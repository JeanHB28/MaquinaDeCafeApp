namespace MaquinaDeCafeApp
{
    public class MaquinaDeCafe
    {
        private Cafetera cafetera;
        private Vaso vasosPequeno;
        private Vaso vasosMediano;
        private Vaso vasosGrande;
        private Azucarero azucarero;

        public void setCafetera(Cafetera cafetera)
        {
            this.cafetera = cafetera;
        }

        public Cafetera getCafetera()
        {
            return cafetera;
        }

        public void setVasosPequeno(Vaso vaso)
        {
            this.vasosPequeno = vaso;
        }

        public Vaso getVasosPequeno()
        {
            return vasosPequeno;
        }

        public void setVasosMediano(Vaso vaso)
        {
            this.vasosMediano = vaso;
        }

        public Vaso getVasosMediano()
        {
            return vasosMediano;
        }

        public void setVasosGrande(Vaso vaso)
        {
            this.vasosGrande = vaso;
        }

        public Vaso getVasosGrande()
        {
            return vasosGrande;
        }

        public void setAzucarero(Azucarero azucarero)
        {
            this.azucarero = azucarero;
        }

        public Azucarero getAzucarero()
        {
            return azucarero;
        }

        public Vaso getTipoVaso(string tipoVaso)
        {
            switch (tipoVaso.ToLower())
            {
                case "pequeno":
                    return vasosPequeno;
                case "mediano":
                    return vasosMediano;
                case "grande":
                    return vasosGrande;
                default:
                    return null;
            }
        }

        public string getVasoDeCafe(Vaso vaso, int cantidadVasos, int cantidadAzucar)
        {
            if (!vaso.hasVasos(cantidadVasos))
            {
                return "No hay Vasos";
            }
            if (!cafetera.hasCafe(vaso.getContenido() * cantidadVasos))
            {
                return "No hay Cafe";
            }
            if (!azucarero.hasAzucar(cantidadAzucar))
            {
                return "No hay Azucar";
            }
            vaso.giveVasos(cantidadVasos);
            cafetera.giveCafe(vaso.getContenido() * cantidadVasos);
            azucarero.giveAzucar(cantidadAzucar);
            return "Felicitaciones";
        }
    }
} 
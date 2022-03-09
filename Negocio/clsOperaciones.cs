namespace Negocio
{
    public class clsOperaciones
    {
        private double dblnumero1;
        private double dblnumero2;
        private double dblresultaddo;
        private string str_Mensaje;

        public clsOperaciones()
        {
            this.dblresultaddo = 0;
            this.dblnumero1 = 0;
            this.dblnumero2 = 0;
            this.str_Mensaje = "";
        }

        public void setCalcularOperacion (int op)
        {
            if (this.dblnumero1 ==0 || this.dblnumero2 == 0)
            {
                this.str_Mensaje = "debe actualizar las " +
                    "variables de instancia";
            }
            else
            {
                this.str_Mensaje = "";
                if (op == 0)
                {
                    this.dblresultaddo = this.dblnumero1 + this.dblnumero2;
                }
                if (op == 1)
                {
                    this.dblresultaddo = this.dblnumero1 - this.dblnumero2;
                }
                if (op == 2)
                {
                    this.dblresultaddo = this.dblnumero1 * this.dblnumero2;
                }    
                if (op == 3)
                {
                    if (this.dblnumero2 == 0)
                    {
                        this.str_Mensaje = "Operacion no valida #Div0";
                    }
                    else
                    {
                        this.str_Mensaje = "";
                        this.dblresultaddo = this.dblnumero1 / this.dblnumero2;
                    }
                }
            }
        }

        //setters
        public void setnumero1 (double n1) { this.dblnumero1 = n1; }
        public void setnumero2 (double n2) { this.dblnumero2 = n2;}

        //getters
        public double getnumero1 () { return this.dblnumero1; }
        public double getdblnumero2 () { return this.dblnumero2; }
        public double getresultado () { return this.dblresultaddo; }
        public string getmensaje () { return this.str_Mensaje; }
    }
}

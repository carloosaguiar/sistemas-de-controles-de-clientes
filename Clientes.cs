namespace ControleSistemas
{
    public class Clientes
    {
        // Atributos da Classe-Pai Clientes
        public string nome {get; set;}
        public string enderenco {get; set;}
        public float valor {get; protected set;}
        public float valor_imposto {get; protected set;}
        public float total {get; protected set;}

        // Metodo para pagar o Imposto
        public virtual void PagarImposto(float v){
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}
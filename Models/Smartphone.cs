namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // Realizado!!
        protected string Modelo { get; set; }
        protected string IMEI { get; set; }
       protected int Memoria { get; set; }


        public Smartphone(string numero, string imei, string modelo, int memoria)
        {
            Numero = numero;
            // Realizado!!
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        
    }
}
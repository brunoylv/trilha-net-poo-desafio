namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public int Memoria { get; set; }

        public string IMEI { get; set; }

        public string Modelo { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama

        public Smartphone(string numero, int memoria, string iMEI, string modelo)
        {
            Numero = numero;
            Memoria = memoria;
            IMEI = iMEI;
            Modelo = modelo;
            // TODO: Passar os parâmetros do construtor para as propriedades
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Número: {Numero}, Capacidade de Memória = {Memoria} GB, IMEI = {IMEI}, Modelo: {Modelo}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
namespace ProjetoEstacionamento.Models
{

    public class Estacionamento
    {
            private int PrecoInicial;
            private int  PrecoPorHora;
            private List<string> Veiculos = new List<string>();

        public Estacionamento(int precoInicial, int precoPorHora)
        {
           PrecoInicial = precoInicial;
           PrecoPorHora = precoPorHora;

        }

        public void AdicionarVeiculo(){
            
            Console.WriteLine("Digite a placa do veiculo para estacionar: ");
            string placa = Console.ReadLine() ?? "AAA-1234";
            Veiculos.Add(placa);
        }

        public void SaidaDeVeiculo(){
            
            Console.WriteLine("Digite a placa do veiculo que ira Sair: ");
            string placa = Console.ReadLine() ?? "";
            Veiculos.Remove(placa);

            Console.WriteLine("Digite a quantidade de horas que o veiculo permaceu estacionado: ");
            int HoraEstacionado =  Convert.ToInt32(Console.ReadLine());

            decimal TotalPorHora = PrecoPorHora * HoraEstacionado;
            decimal TotalPeloEstacionamento = TotalPorHora + PrecoInicial;

            Console.WriteLine($"O veiculo {placa} saiu do estacionamento, o preço total foi de: R$ {TotalPeloEstacionamento}");
        }

        public void  ListarVeiculos(){
            
            Console.WriteLine("Os veiculos estacionados são: ");
            foreach (var item in Veiculos)
            {
                Console.WriteLine(item);
            }
        }
    }
}
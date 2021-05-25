using Refit;
using System;
using System.Threading.Tasks;

namespace ExemploRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                var cepClient = RestService.For<ICEPApiService>("http://viacep.com.br");

                Console.WriteLine("Informe seu cep:");
                string cepInput = Console.ReadLine().ToString();

                Console.WriteLine("Consultando informações do CEP: " + cepInput);

                var infoCep = await cepClient.GetInfoCepAsync(cepInput);

                Console.WriteLine($"\nLogradouro: {infoCep.Logradouro},\nBairro: {infoCep.Bairro},\nCidade: {infoCep.Localidade} - UF: {infoCep.Uf}");
                Console.ReadKey();


            }
            catch (Exception e)
            {
                Console.WriteLine("Erro na consulta de cep: " + e.Message);
            }
        }
    }
}

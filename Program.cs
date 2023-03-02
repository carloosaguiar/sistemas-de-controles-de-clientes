using System;

namespace ControleSistemas
{
    public class Program
    {
        static void Main(string[] args){

            float val_pag;

            Console.WriteLine("Informar nome: ");
            string var_nome = Console.ReadLine();

            Console.WriteLine("Informar Endereço: ");
            string var_endereco = Console.ReadLine();

            Console.WriteLine("Pessoa Física (f) ou Pessoa Juridica (j)?");
            string var_tipo_conta = Console.ReadLine();

            //Caso a conta da pessoa é fisica
            if(var_tipo_conta == "f"){  
                Pessoa_Fisica pf = new Pessoa_Fisica();

                pf.nome = var_nome;
                pf.enderenco = var_endereco;

                Console.WriteLine("Informar CPF: ");
                pf.cpf = Console.ReadLine();

                Console.WriteLine("Informar RG: ");
                pf.rg = Console.ReadLine();

                Console.WriteLine("Informar Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());

                pf.PagarImposto(val_pag);

                Console.WriteLine($@"
                -------- Pessoa Física --------- 
                Nome ..........: {pf.nome}
                Endereço ......: {pf.enderenco}
                CPF ...........: {pf.rg}
                RG.............: {pf.cpf}
                Valor da Compra: {pf.valor.ToString("C")}
                Imposto .......: {pf.valor_imposto.ToString("C")}
                Total a Pagar  : {pf.total.ToString("C")}
                ");
            }   

            //Caso a conta da pessoa é juridica
            if(var_tipo_conta == "j"){
                Pessoa_Jurudica pj = new Pessoa_Jurudica();

                pj.nome = var_nome;
                pj.enderenco = var_endereco;

                Console.WriteLine("Informar CNPJ: ");
                pj.cnpj = Console.ReadLine();

                Console.WriteLine("Informar IE: ");
                pj.ie = Console.ReadLine();

                Console.WriteLine("Informar Valor da Compra: ");
                val_pag = float.Parse(Console.ReadLine());

                pj.PagarImposto(val_pag);

                Console.WriteLine($@"
                -------- Pessoa Física --------- 
                Nome ..........: {pj.nome}
                Endereço ......: {pj.enderenco}
                CNPJ ..........: {pj.cnpj}
                IE ............: {pj.ie}
                Valor da Compra: {pj.valor.ToString("C")}
                Imposto .......: {pj.valor_imposto.ToString("C")}
                Total a Pagar  : {pj.total.ToString("C")}
                ");
            }

        }
    }
}
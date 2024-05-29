
//FAÇA UM PROGRAMA ESTILO CAIXA ELETRÔNICO,

//QUE O USUÁRIO CONSIGA VER O SALDO, DEPOSITAR E SACAR DINHEIRO.

//OBS: USAR MÉTODOS NO DESENVOLVIMENTO
 

int retornarDeposito;

int saldo = 0;

int _ = saldo;

int tentativas = 1;

bool bloqueado = false;

int senha;

int maxTentativas = 4;


Console.WriteLine("ANTES DE INICIAR, CADASTRE UMA NOVA CONTA!");

string novoUsuario = Console.ReadLine();

Console.WriteLine("CADASTRE UMA SENHA DE 4 DIGITOS!");

int novaSenha = int.Parse(Console.ReadLine());

Console.Clear();

Console.WriteLine("///////CONTA E SENHA CADASTRADO COM SUCESSO///////");

Console.WriteLine();


Login();

int opcoes = 0;


void Login()

{

    Console.WriteLine("INFORME UMA CONTA!");

    string usuario = Console.ReadLine();

    Console.Clear();

    while (usuario != novoUsuario || usuario == novoUsuario)

    {

        if (usuario == novoUsuario)

        {

            Senha();

            break;

        }

        else

        {

            Console.WriteLine("CONTA NÃO ENCONTRADA, DIGITE NOVAMENTE!");

            usuario = Console.ReadLine();

            Console.Clear();

        }

    }

}


void Senha()

{

    Console.WriteLine("INFORME SUA SENHA DE 4 DIGITOS!");

    int senhaDigitada = int.Parse(Console.ReadLine());

    Console.Clear();

    while (senhaDigitada != novaSenha || senhaDigitada == novaSenha)

    {

        if (senhaDigitada == novaSenha)

        {

            Console.WriteLine("SENHA CORRETA");

            Console.Clear();

            break;

        }

        else

        {

            senhaDigitada = BloquearSenha(senhaDigitada);

        }

    }

    Console.WriteLine();

    Console.WriteLine($"===== SEJA BEM VINDO {novoUsuario} =======");

    Console.WriteLine();

}


int BloquearSenha(int senhaDigitada)

{

    while (senhaDigitada != novaSenha)

    {

        Console.WriteLine("SENHA INCORRETA.");

        Console.WriteLine($"VOCÊ TEM {maxTentativas - tentativas} TENTATIVAS RESTANTES.");

        senhaDigitada = int.Parse(Console.ReadLine());

        tentativas++;

        Console.Clear();

        if (senhaDigitada == novaSenha)

        {

            Console.WriteLine();

            Console.WriteLine("SENHA CORRETA. ACESSO CONCEDIDO.");

        }

        else if (maxTentativas <= tentativas)

        {

            Console.WriteLine("VOCÊ EXCEDEU O NÚMERO MÁXIMO DE TENTATIVAS!");

            Console.WriteLine();

            Console.WriteLine("SUA CONTA ESTÁ BLOQUEADA. POR FAVOR, CONTATE O SUPORTE.");

            Environment.Exit(0);

        }

    }

    Console.WriteLine();

    Console.WriteLine($"===== SEJA BEM VINDO {novoUsuario} =======");

    Console.WriteLine();

    return senhaDigitada;

}

while (opcoes != 4)

{

    opcoes = Menu();

    Console.Clear();

    switch (opcoes)

    {

        case 1:

            Depositar();

            break;

        case 2:

            Saldo();

            break;

        case 3:

            Sacar();

            break;

        case 4:

            Console.WriteLine("FIM DO PROCESSO APERTE ENTER OU SAIR....");

            break;

    }

}

Console.ReadKey();

static int Menu()

{

    Console.WriteLine("===================");

    Console.WriteLine("  MENU DE OPÇÕES");

    Console.WriteLine("===================");

    Console.WriteLine("[1] DEPOSITAR");

    Console.WriteLine("[2] MOSTRAR SALDO");

    Console.WriteLine("[3] SACAR");

    Console.WriteLine("[4] SAIR");

    int opcoes = int.Parse(Console.ReadLine());

    return opcoes;

}

void Saldo()

{

    Console.WriteLine($"SALDO ATUAL: R$ {saldo}");

    Console.WriteLine();

}

void Depositar()

{

    Console.WriteLine("INFORME O VALOR DESEJADO PARA DEPOSITO!");

    double deposito = double.Parse(Console.ReadLine());

    Console.Clear();

    if (deposito > 0)

    {

        saldo = (int)(saldo + deposito);

        Console.WriteLine($"DEPÓSITO DE R$ {deposito} REALIZADO COM SUCESSO.");

        Console.WriteLine();

    }

    else

    {

        Console.WriteLine($"ERRO : R$ {deposito} DIGITO INVALIDO");

        Console.WriteLine();

    }

}

void Sacar()

{

    Console.WriteLine("INFORME O VALOR QUE DESEJA SACAR!");

    double sacar = double.Parse(Console.ReadLine());

    Console.Clear();

    if (sacar <= 0)

    {

        Console.WriteLine("NÃO É PERMITIDO SACAR VALORES NEGATIVOS OU ZERO.");

        Console.WriteLine();

    }

    else if (saldo >= sacar)
    {
        saldo = (int)(saldo - sacar);
        Console.WriteLine($"SAQUE DE R$ {sacar} REALIZADO COM SUCESSO.");
        Console.WriteLine();
        Console.WriteLine($"SALDO : {saldo}");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine($"ERRO : VALOR R$ {sacar} INDISPONIVEL");
        Console.WriteLine();
        Console.WriteLine($"SALDO R$ {saldo}");
        Console.WriteLine();
    }
}
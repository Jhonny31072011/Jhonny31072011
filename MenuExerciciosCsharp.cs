using System;
using System.Globalization;
using System.Threading;

class MenuExercicios
{
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                    MENU DE EXERCÍCIOS - PROGRAMAÇÃO EM C#                      ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("\n📋 SLIDE - MENU GERAL DE EXERCÍCIOS");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("1  - Soma dos Pares: soma números pares fornecidos pelo usuário até negativo");
            Console.WriteLine("2  - Contador Maior que 100: conta quantos números maiores que 100 são inseridos");
            Console.WriteLine("\n📊 BÁSICO - OPERAÇÕES FUNDAMENTAIS");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("3  - Entrada e Saída: lê nome e ano, calcula e exibe idade do usuário");
            Console.WriteLine("4  - Inversão de Números: lê dois números e exibe-os em ordem invertida");
            Console.WriteLine("5  - Salário com Desconto: calcula salário bruto, descontos e salário líquido");
            Console.WriteLine("6  - Conversor Celsius-Fahrenheit: converte temperatura de graus Celsius");
            Console.WriteLine("7  - Média Aritmética: calcula média entre dois valores inseridos");
            Console.WriteLine("8  - Conversor Km/h para m/s: converte velocidade de quilômetros para metros");
            Console.WriteLine("9  - Salário com Previdência: calcula descontos de previdência e imposto");
            Console.WriteLine("10 - Inversor de Algarismos: inverte um número de 3 dígitos automaticamente");
            Console.WriteLine("\n⚡ CONDICIONAIS - IF/ELSE E SWITCH");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("11 - Aumento Condicional de Salário: se salário ≤ 150, adiciona 30 reais");
            Console.WriteLine("12 - Aprovação/Reprovação: valida média de notas (maior/igual 7 aprovado)");
            Console.WriteLine("13 - Comparador de Números: compara dois números e indica o maior ou iguais");
            Console.WriteLine("14 - Dias da Semana: exibe dia da semana baseado em número de 1 a 7");
            Console.WriteLine("15 - Validador de Vogais: identifica se uma letra é vogal ou consoante");
            Console.WriteLine("16 - Menu de Produtos: exibe código, nome e preço de lanches com seleção");
            Console.WriteLine("17 - Selecionador de Classe RPG: escolhe classe e exibe item inicial");
            Console.WriteLine("18 - Avaliador de Atendimento: classifica avaliação de 1 a 5 do restaurante");
            Console.WriteLine("19 - Conversor de Números: transforma número (1-5) para extenso por switch");
            Console.WriteLine("20 - Calculadora Básica: realiza operações (+, -, *, /) com validação divisão");
            Console.WriteLine("21 - Classificador de Idade: categoriza idade em infantil, juvenil ou sênior");
            Console.WriteLine("22 - Menu Lanchonete: seleciona produto, quantidade e calcula total a pagar");
            Console.WriteLine("23 - Calculador de Imposto: aplica taxa de imposto por estado (SP,RJ,MG,ES)");
            Console.WriteLine("24 - Calculador de Peso Planetário: calcula peso em diferentes planetas");
            Console.WriteLine("25 - Estações do Ano: exibe estação conforme número do mês (1-12)");
            Console.WriteLine("\n💰 DESAFIO RH - SISTEMA COMPLETO");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("26 - Sistema de RH TechCorp: calcula salário final com bônus por cargo");
            Console.WriteLine("\n🔄 LOOPS - WHILE E DO-WHILE");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.WriteLine("27 - Soma de Números Menores 20: soma valores até 0, ignorando maiores");
            Console.WriteLine("28 - Média de Idades: calcula média de idades até inserir número negativo");
            Console.WriteLine("29 - Validador de Senha: solicita senha até acertar a correta (1234)");
            Console.WriteLine("30 - Maior Número: encontra o maior entre vários números inseridos");
            Console.WriteLine("31 - Validador de Notas: valida nota entre 0-10 com tentativas ilimitadas");
            Console.WriteLine("32 - Menu Interativo While: menu simples com opções (Olá, Ano, Sair)");
            Console.WriteLine("33 - Contagem Regressiva: conta de trás para frente com som de foguete");
            Console.WriteLine("34 - Somador com Acumulador: soma números inseridos até digitar 0");
            Console.WriteLine("\n0  - SAIR DO PROGRAMA");
            Console.WriteLine("═══════════════════════════════════════════════════════════════════════════════════");
            Console.Write("\nDigite a opção desejada: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("❌ Opção inválida! Tente novamente.");
                Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    Console.Clear();
                    SomaDosParesSlide();
                    break;
                case 2:
                    Console.Clear();
                    ContadorMaiorQue100Slide();
                    break;
                case 3:
                    Console.Clear();
                    EntradaSaida();
                    break;
                case 4:
                    Console.Clear();
                    InversaoDois();
                    break;
                case 5:
                    Console.Clear();
                    SalarioComDesconto();
                    break;
                case 6:
                    Console.Clear();
                    ConversorCelsiusFahrenheit();
                    break;
                case 7:
                    Console.Clear();
                    MediaAritmetica();
                    break;
                case 8:
                    Console.Clear();
                    ConversorVelocidade();
                    break;
                case 9:
                    Console.Clear();
                    SalarioComPrevidencia();
                    break;
                case 10:
                    Console.Clear();
                    InversorAlgarismos();
                    break;
                case 11:
                    Console.Clear();
                    AumentoCondicional();
                    break;
                case 12:
                    Console.Clear();
                    AprovacaoReprovacao();
                    break;
                case 13:
                    Console.Clear();
                    ComparadorNumeros();
                    break;
                case 14:
                    Console.Clear();
                    DiasDaSemana();
                    break;
                case 15:
                    Console.Clear();
                    ValidadorVogais();
                    break;
                case 16:
                    Console.Clear();
                    MenuProdutos();
                    break;
                case 17:
                    Console.Clear();
                    SeletorClasseRPG();
                    break;
                case 18:
                    Console.Clear();
                    AvaliadorAtendimento();
                    break;
                case 19:
                    Console.Clear();
                    ConversorNumeros();
                    break;
                case 20:
                    Console.Clear();
                    CalculadoraBasica();
                    break;
                case 21:
                    Console.Clear();
                    ClassificadorIdade();
                    break;
                case 22:
                    Console.Clear();
                    MenuLanchonete();
                    break;
                case 23:
                    Console.Clear();
                    CalculadorImposto();
                    break;
                case 24:
                    Console.Clear();
                    CalculadorPesoPlanetario();
                    break;
                case 25:
                    Console.Clear();
                    EstacoesAno();
                    break;
                case 26:
                    Console.Clear();
                    SistemaRHTechCorp();
                    break;
                case 27:
                    Console.Clear();
                    SomaMenor20();
                    break;
                case 28:
                    Console.Clear();
                    MediaIdades();
                    break;
                case 29:
                    Console.Clear();
                    ValidadorSenha();
                    break;
                case 30:
                    Console.Clear();
                    MaiorNumero();
                    break;
                case 31:
                    Console.Clear();
                    ValidadorNotas();
                    break;
                case 32:
                    Console.Clear();
                    MenuInterativoWhile();
                    break;
                case 33:
                    Console.Clear();
                    ContagemRegressiva();
                    break;
                case 34:
                    Console.Clear();
                    SomadorAcumulador();
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════╗");
                    Console.WriteLine("║                      OBRIGADO POR USAR O MENU! ATÉ LOGO! 👋                   ║");
                    Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════╝");
                    return;
                default:
                    Console.WriteLine("❌ Opção inválida! Tente novamente.");
                    Console.ReadKey();
                    break;
            }
        } while (true);
    }

    // ==================== EXERCÍCIOS SLIDE ====================
    static void SomaDosParesSlide()
    {
        Console.WriteLine("📌 SOMA DOS PARES");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;
        int soma = 0;

        Console.Write("Informe um número (negativo para sair): ");
        numero = int.Parse(Console.ReadLine());

        do
        {
            if (numero >= 0 && numero % 2 == 0)
            {
                soma = soma + numero;
            }
            Console.Write("Informe um número (negativo para sair): ");
            numero = int.Parse(Console.ReadLine());
        } while (numero >= 0);

        Console.WriteLine($"\n✅ A soma dos pares é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ContadorMaiorQue100Slide()
    {
        Console.WriteLine("📌 CONTADOR MAIOR QUE 100");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;
        int contador = 0;

        Console.Write("Digite um número inteiro (0 para SAIR): ");
        numero = int.Parse(Console.ReadLine());

        do
        {
            if (numero > 100)
            {
                contador++;
            }
            if (numero != 0)
            {
                Console.Write("Digite um número inteiro (0 para SAIR): ");
                numero = int.Parse(Console.ReadLine());
            }
        } while (numero != 0);

        Console.WriteLine($"\n✅ A quantidade de números maiores que 100 é: {contador}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== EXERCÍCIOS BÁSICOS ====================
    static void EntradaSaida()
    {
        Console.WriteLine("📌 ENTRADA E SAÍDA - CÁLCULO DE IDADE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        string nome;
        int ano;

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Informe seu ano de nascimento: ");
        ano = int.Parse(Console.ReadLine());

        int idade = 2026 - ano;

        Console.WriteLine($"\n✅ Bom dia, {nome}, seja bem-vindo!");
        Console.WriteLine($"{nome}, você tem {idade} anos!");
        Console.WriteLine($"Ano que vem você fará {idade + 1} anos!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void InversaoDois()
    {
        Console.WriteLine("📌 INVERSÃO DE DOIS NÚMEROS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numA, numB;

        Console.Write("Informe o primeiro número: ");
        numA = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        numB = int.Parse(Console.ReadLine());

        Console.WriteLine($"\n✅ Os números que você digitou foram: {numB} e {numA}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SalarioComDesconto()
    {
        Console.WriteLine("📌 CÁLCULO DE SALÁRIO COM DESCONTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double HT, VH, PD, SB, TD, SL;

        Console.Write("Informe a quantidade de horas trabalhadas no mês: ");
        HT = double.Parse(Console.ReadLine());
        Console.Write("Informe o valor da hora trabalhada: ");
        VH = double.Parse(Console.ReadLine());
        Console.Write("Informe o percentual de desconto: ");
        PD = double.Parse(Console.ReadLine());

        SB = HT * VH;
        TD = (PD / 100) * SB;
        SL = SB - TD;

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                        ✅ RESUMO                             ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Horas trabalhadas: {HT} horas");
        Console.WriteLine($"║ Salário Bruto: R$ {SB:F2}");
        Console.WriteLine($"║ Total de descontos: R$ {TD:F2}");
        Console.WriteLine($"║ Salário Líquido: R$ {SL:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorCelsiusFahrenheit()
    {
        Console.WriteLine("📌 CONVERSOR CELSIUS PARA FAHRENHEIT");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double C, F;

        Console.Write("Informe a temperatura em Graus Celsius: ");
        C = double.Parse(Console.ReadLine());

        F = (9 * C + 160) / 5;

        Console.WriteLine($"\n✅ {C}° Graus Celsius são {F}° Fahrenheit");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MediaAritmetica()
    {
        Console.WriteLine("📌 CÁLCULO DE MÉDIA ARITMÉTICA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double val1, val2, media;

        Console.Write("Informe o primeiro valor: ");
        val1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        val2 = double.Parse(Console.ReadLine());

        media = (val1 + val2) / 2;

        Console.WriteLine($"\n✅ A média entre {val1} e {val2} é {media}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorVelocidade()
    {
        Console.WriteLine("📌 CONVERSOR VELOCIDADE KM/H PARA M/S");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double velocidadeKmh, velocidadems;

        Console.Write("Informe a velocidade em m/s: ");
        velocidadems = double.Parse(Console.ReadLine());

        velocidadeKmh = velocidadems / 3.6;

        Console.WriteLine($"\n✅ {velocidadems} m/s são {velocidadeKmh} Km/h");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SalarioComPrevidencia()
    {
        Console.WriteLine("📌 SALÁRIO COM PREVIDÊNCIA SOCIAL E IMPOSTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double SB, PrevSocial, Imposto, SL;

        Console.Write("Informe o seu salário bruto: ");
        SB = double.Parse(Console.ReadLine());

        PrevSocial = SB * 0.10;
        Imposto = (SB - PrevSocial) * 0.05;
        SL = SB - PrevSocial - Imposto;

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ✅ RESUMO FINAL                           ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Salário Bruto: R$ {SB:F2}");
        Console.WriteLine($"║ Previdência Social: R$ {PrevSocial:F2}");
        Console.WriteLine($"║ Imposto: R$ {Imposto:F2}");
        Console.WriteLine($"║ Salário Líquido: R$ {SL:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void InversorAlgarismos()
    {
        Console.WriteLine("📌 INVERSOR DE 3 ALGARISMOS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int N, C, D, U, M;

        Console.Write("Informe um número com 3 algarismos: ");
        N = int.Parse(Console.ReadLine());

        C = N / 100;
        D = (N % 100) / 10;
        U = (N % 100) % 10;

        M = (U * 100) + (D * 10) + C;

        Console.WriteLine($"\n✅ O número inverso é: {M}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== CONDICIONAIS ====================
    static void AumentoCondicional()
    {
        Console.WriteLine("📌 AUMENTO CONDICIONAL DE SALÁRIO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        string nome;
        double salario;

        Console.Write("Informe seu nome: ");
        nome = Console.ReadLine();
        Console.Write("Informe o seu salário: ");
        salario = double.Parse(Console.ReadLine());

        if (salario <= 150)
        {
            salario = salario + 30;
        }

        Console.WriteLine($"\n✅ {nome}, seu novo salário é: R$ {salario:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void AprovacaoReprovacao()
    {
        Console.WriteLine("📌 APROVAÇÃO/REPROVAÇÃO POR MÉDIA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double nota1, nota2, nota3, media;

        Console.Write("Informe a sua 1ª nota: ");
        nota1 = double.Parse(Console.ReadLine());
        Console.Write("Informe a sua 2ª nota: ");
        nota2 = double.Parse(Console.ReadLine());
        Console.Write("Informe a sua 3ª nota: ");
        nota3 = double.Parse(Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine($"\n✅ Aluno APROVADO com média {media:F2}");
        }
        else
        {
            Console.WriteLine($"\n❌ Aluno REPROVADO com média {media:F2}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ComparadorNumeros()
    {
        Console.WriteLine("📌 COMPARADOR DE NÚMEROS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int num1, num2;

        Console.Write("Informe o primeiro valor: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo valor: ");
        num2 = int.Parse(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"\n✅ O número {num1} é o maior!");
        }
        else if (num2 > num1)
        {
            Console.WriteLine($"\n✅ O número {num2} é o maior!");
        }
        else
        {
            Console.WriteLine($"\n✅ Os números {num1} e {num2} são iguais!");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void DiasDaSemana()
    {
        Console.WriteLine("📌 DIAS DA SEMANA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Informe o número para o dia da semana (1-7): ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Domingo");
                break;
            case 2:
                Console.WriteLine("\n✅ Segunda-feira");
                break;
            case 3:
                Console.WriteLine("\n✅ Terça-feira");
                break;
            case 4:
                Console.WriteLine("\n✅ Quarta-feira");
                break;
            case 5:
                Console.WriteLine("\n✅ Quinta-feira");
                break;
            case 6:
                Console.WriteLine("\n✅ Sexta-feira");
                break;
            case 7:
                Console.WriteLine("\n✅ Sábado");
                break;
            default:
                Console.WriteLine("\n❌ Número inválido. Informe um número entre 1 e 7.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorVogais()
    {
        Console.WriteLine("📌 VALIDADOR DE VOGAIS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        char letra;

        Console.Write("Informe uma letra: ");
        letra = char.ToUpper(Console.ReadLine()[0]);

        switch (letra)
        {
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("\n✅ A letra é uma VOGAL.");
                break;
            default:
                Console.WriteLine("\n❌ A letra é uma CONSOANTE!");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuProdutos()
    {
        Console.WriteLine("📌 MENU DE PRODUTOS");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Cachorro-Quente.....001");
        Console.WriteLine("X-Salada.....002");
        Console.WriteLine("X-Bacon.....003");
        Console.WriteLine("Bauru.....004");
        Console.WriteLine("Refrigerante.....005");

        Console.Write("\nInforme o código do produto: ");
        double codigoProduto = double.Parse(Console.ReadLine());
        Console.Clear();

        string nomeProduto = "";
        double preço = 0;

        switch (codigoProduto)
        {
            case 1:
                nomeProduto = "Cachorro Quente";
                preço = 10.00;
                break;
            case 2:
                nomeProduto = "X-Salada";
                preço = 15.00;
                break;
            case 3:
                nomeProduto = "X-Bacon";
                preço = 18.00;
                break;
            case 4:
                nomeProduto = "Bauru";
                preço = 12.00;
                break;
            case 5:
                nomeProduto = "Refrigerante";
                preço = 8.00;
                break;
            default:
                Console.WriteLine("\n❌ Código de produto inválido.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        Console.WriteLine($"\n✅ Produto: {nomeProduto}");
        Console.WriteLine($"💰 Preço: R$ {preço:F2}");
        Console.WriteLine("\n✅ Obrigado pela preferência!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SeletorClasseRPG()
    {
        Console.WriteLine("📌 SELETOR DE CLASSE RPG");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Bem-vindo ao mundo de RPG!");
        Console.WriteLine("═════════════════════════════");
        Console.WriteLine("G - Guerreiro");
        Console.WriteLine("M - Mago");
        Console.WriteLine("A - Arqueiro");

        Console.Write("\nDigite a letra correspondente à classe: ");
        string classe = Console.ReadLine().ToUpper();

        switch (classe)
        {
            case "G":
                Console.WriteLine("\n✅ Bem-vindo, Guerreiro! Você começa com uma ESPADA.");
                break;
            case "M":
                Console.WriteLine("\n✅ Bem-vindo, Mago! Você começa com um CAJADO.");
                break;
            case "A":
                Console.WriteLine("\n✅ Bem-vindo, Arqueiro! Você começa com um ARCO.");
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida. Por favor, escolha G, M ou A.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void AvaliadorAtendimento()
    {
        Console.WriteLine("📌 AVALIADOR DE ATENDIMENTO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Informe uma nota de 1 a 5 para avaliar nosso atendimento: ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Atendimento avaliado como: PÉSSIMO!");
                break;
            case 2:
                Console.WriteLine("\n✅ Atendimento avaliado como: RUIM!");
                break;
            case 3:
                Console.WriteLine("\n✅ Atendimento avaliado como: RAZOÁVEL!");
                break;
            case 4:
                Console.WriteLine("\n✅ Atendimento avaliado como: BOM!");
                break;
            case 5:
                Console.WriteLine("\n✅ Atendimento avaliado como: EXCELENTE!");
                break;
            default:
                Console.WriteLine("\n❌ Nota fora do intervalo. Informe um número entre 1 e 5.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ConversorNumeros()
    {
        Console.WriteLine("📌 CONVERSOR DE NÚMEROS (1-5)");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero;

        Console.Write("Digite um número de 1 a 5: ");
        numero = int.Parse(Console.ReadLine());

        switch (numero)
        {
            case 1:
                Console.WriteLine("\n✅ Um");
                break;
            case 2:
                Console.WriteLine("\n✅ Dois");
                break;
            case 3:
                Console.WriteLine("\n✅ Três");
                break;
            case 4:
                Console.WriteLine("\n✅ Quatro");
                break;
            case 5:
                Console.WriteLine("\n✅ Cinco");
                break;
            default:
                Console.WriteLine("\n❌ Número fora do limite. Informe um número entre 1 e 5.");
                break;
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadoraBasica()
    {
        Console.WriteLine("📌 CALCULADORA BÁSICA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        double num1, num2, resultado = 0;
        char operador;
        bool operadorValido = true;

        Console.Write("Digite o primeiro número: ");
        num1 = double.Parse(Console.ReadLine());
        Console.Write("Digite o operador (+, -, *, /): ");
        operador = char.Parse(Console.ReadLine());
        Console.Write("Digite o segundo número: ");
        num2 = double.Parse(Console.ReadLine());

        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                {
                    Console.WriteLine("\n❌ Erro: Divisão por zero não permitida.");
                    operadorValido = false;
                }
                break;
            default:
                Console.WriteLine("\n❌ Operador inválido.");
                operadorValido = false;
                break;
        }

        if (operadorValido)
        {
            Console.WriteLine($"\n✅ Resultado: {num1} {operador} {num2} = {resultado}");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ClassificadorIdade()
    {
        Console.WriteLine("📌 CLASSIFICADOR DE IDADE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.Write("Digite a idade: ");
        if (int.TryParse(Console.ReadLine(), out int idade))
        {
            string categoria;

            if (idade >= 0 && idade <= 12)
            {
                categoria = "Infantil";
            }
            else if (idade >= 13 && idade <= 17)
            {
                categoria = "Juvenil";
            }
            else if (idade >= 18)
            {
                categoria = "Sênior";
            }
            else
            {
                categoria = "Idade inválida";
            }

            Console.WriteLine($"\n✅ A categoria é: {categoria}");
        }
        else
        {
            Console.WriteLine("\n❌ Por favor, insira um número válido.");
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuLanchonete()
    {
        Console.WriteLine("📌 MENU LANCHONETE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Bem-vindo à Lanchonete!");
        Console.WriteLine("═════════════════════════════════════════════════════════════════");
        Console.WriteLine("Código - Produto - Preço");
        Console.WriteLine("100 - Cachorro Quente - R$ 15,00");
        Console.WriteLine("101 - Bauru - R$ 18,00");
        Console.WriteLine("102 - Hambúrguer - R$ 20,00");
        Console.WriteLine("103 - Cheeseburguer - R$ 22,00");
        Console.WriteLine("104 - Refrigerante - R$ 8,00");

        Console.Write("\nDigite o código do produto: ");
        int codigoProduto = int.Parse(Console.ReadLine());
        Console.Write("Digite a quantidade desejada: ");
        int quantidade = int.Parse(Console.ReadLine());

        double preço = 0;
        switch (codigoProduto)
        {
            case 100:
                preço = 15.00;
                break;
            case 101:
                preço = 18.00;
                break;
            case 102:
                preço = 20.00;
                break;
            case 103:
                preço = 22.00;
                break;
            case 104:
                preço = 8.00;
                break;
            default:
                Console.WriteLine("\n❌ Código de produto inválido.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        double valorTotal = preço * quantidade;
        Console.WriteLine($"\n✅ O valor total a ser pago é: R$ {valorTotal:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadorImposto()
    {
        Console.WriteLine("📌 CALCULADOR DE IMPOSTO POR ESTADO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Estados: SP (+10%), RJ (+15%), MG (+12%), ES (+8%)");

        Console.Write("\nInfome o valor base do produto: ");
        string entradaValor = Console.ReadLine().Trim().Replace(',', '.');
        if (!decimal.TryParse(entradaValor, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal valorBase) || valorBase < 0)
        {
            Console.WriteLine("\n❌ Valor inválido.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        Console.Write("Informe a sigla do estado (SP, RJ, MG, ES): ");
        string estado = Console.ReadLine()?.Trim().ToUpperInvariant();

        decimal taxa;
        switch (estado)
        {
            case "SP":
                taxa = 0.10m;
                break;
            case "RJ":
                taxa = 0.15m;
                break;
            case "MG":
                taxa = 0.12m;
                break;
            case "ES":
                taxa = 0.08m;
                break;
            default:
                Console.WriteLine("\n❌ Estado inválido. Use: SP, RJ, MG ou ES.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        decimal valorImposto = Math.Round(valorBase * taxa, 2);
        decimal valorFinal = Math.Round(valorBase + valorImposto, 2);

        Console.WriteLine("\n╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                      ✅ RESULTADO                            ║");
        Console.WriteLine($"║ Estado: {estado}");
        Console.WriteLine($"║ Valor base: R$ {valorBase:F2}");
        Console.WriteLine($"║ Imposto ({taxa * 100:F0}%): R$ {valorImposto:F2}");
        Console.WriteLine($"║ Valor final: R$ {valorFinal:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void CalculadorPesoPlanetario()
    {
        Console.WriteLine("📌 CALCULADOR DE PESO PLANETÁRIO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");

        Console.Write("Informe seu peso na Terra (kg): ");
        string entradaPeso = Console.ReadLine().Trim().Replace(',', '.');
        if (!double.TryParse(entradaPeso, NumberStyles.Number, CultureInfo.InvariantCulture, out double pesoTerra) || pesoTerra < 0)
        {
            Console.WriteLine("\n❌ Peso inválido.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        Console.WriteLine("\nEscolha o planeta:");
        Console.WriteLine("1 - Mercúrio (Gravidade: 0.37)");
        Console.WriteLine("2 - Vênus    (Gravidade: 0.88)");
        Console.WriteLine("3 - Marte    (Gravidade: 0.38)");
        Console.WriteLine("4 - Júpiter  (Gravidade: 2.64)");
        Console.WriteLine("5 - Saturno  (Gravidade: 1.15)");
        Console.WriteLine("6 - Urano    (Gravidade: 1.17)");

        Console.Write("Digite o número (1-6): ");
        string entradaOpcao = Console.ReadLine();
        if (!int.TryParse(entradaOpcao, out int opcao))
        {
            Console.WriteLine("\n❌ Opção inválida.");
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
            return;
        }

        double gravidade;
        string nomePlaneta = "";
        switch (opcao)
        {
            case 1:
                gravidade = 0.37;
                nomePlaneta = "Mercúrio";
                break;
            case 2:
                gravidade = 0.88;
                nomePlaneta = "Vênus";
                break;
            case 3:
                gravidade = 0.38;
                nomePlaneta = "Marte";
                break;
            case 4:
                gravidade = 2.64;
                nomePlaneta = "Júpiter";
                break;
            case 5:
                gravidade = 1.15;
                nomePlaneta = "Saturno";
                break;
            case 6:
                gravidade = 1.17;
                nomePlaneta = "Urano";
                break;
            default:
                Console.WriteLine("\n❌ Opção inválida. Escolha um número de 1 a 6.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        double novoPeso = Math.Round(pesoTerra * gravidade, 2);
        Console.WriteLine($"\n✅ Seu peso em {nomePlaneta} seria de {novoPeso:F2} kg");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void EstacoesAno()
    {
        Console.WriteLine("📌 ESTAÇÕES DO ANO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("1-Janeiro   | 2-Fevereiro | 3-Março");
        Console.WriteLine("4-Abril     | 5-Maio      | 6-Junho");
        Console.WriteLine("7-Julho     | 8-Agosto    | 9-Setembro");
        Console.WriteLine("10-Outubro  | 11-Novembro | 12-Dezembro");

        Console.Write("\nInforme o número de um mês (1-12): ");
        int mês = int.Parse(Console.ReadLine());

        string estacao = "";
        switch (mês)
        {
            case 12:
            case 1:
            case 2:
                estacao = "VERÃO";
                break;
            case 3:
            case 4:
            case 5:
                estacao = "OUTONO";
                break;
            case 6:
            case 7:
            case 8:
                estacao = "INVERNO";
                break;
            case 9:
            case 10:
            case 11:
                estacao = "PRIMAVERA";
                break;
            default:
                Console.WriteLine("\n❌ Número inválido. Informe um número entre 1 e 12.");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                Console.ReadKey();
                return;
        }

        Console.WriteLine($"\n✅ Estação correspondente: {estacao}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== DESAFIO RH ====================
    static void SistemaRHTechCorp()
    {
        Console.WriteLine("📌 SISTEMA DE RH - TECHCORP");
        Console.WriteLine("════════════════════════════════════════════════════════════════");

        Console.Write("Digite o nome do funcionário: ");
        string nomeFuncionario = Console.ReadLine();
        Console.Write("Digite o salário base: ");
        double salarioBase = double.Parse(Console.ReadLine());

        Console.WriteLine("\n1 - Desenvolvedor Júnior");
        Console.WriteLine("2 - Desenvolvedor Pleno");
        Console.WriteLine("3 - Desenvolvedor Sênior");
        Console.WriteLine("4 - Gerente de Projetos");
        Console.Write("\nDigite o código do cargo: ");
        int codigoCargo = int.Parse(Console.ReadLine());

        string nomeCargo = "";
        double salarioFinal = 0;

        switch (codigoCargo)
        {
            case 1:
                nomeCargo = "Desenvolvedor Júnior";
                Console.Write("Possui certificação C#? (S/N): ");
                string resposta = Console.ReadLine().ToUpper();
                salarioFinal = (resposta == "S") 
                    ? salarioBase + (salarioBase * 0.15)
                    : salarioBase + (salarioBase * 0.05);
                break;
            case 2:
                nomeCargo = "Desenvolvedor Pleno";
                Console.Write("Quantos anos de empresa? ");
                int anos = int.Parse(Console.ReadLine());
                salarioFinal = (anos >= 3)
                    ? salarioBase + (salarioBase * 0.20)
                    : salarioBase + (salarioBase * 0.10);
                break;
            case 3:
                nomeCargo = "Desenvolvedor Sênior";
                Console.Write("É Líder Técnico? (S/N): ");
                string respLider = Console.ReadLine().ToUpper();
                salarioFinal = (respLider == "S")
                    ? salarioBase + (salarioBase * 0.30) + 500
                    : salarioBase + (salarioBase * 0.25);
                break;
            case 4:
                nomeCargo = "Gerente de Projetos";
                Console.Write("Bateu a meta de entregas? (S/N): ");
                string respMeta = Console.ReadLine().ToUpper();
                salarioFinal = (respMeta == "S")
                    ? salarioBase + (salarioBase * 0.40)
                    : salarioBase + (salarioBase * 0.10);
                break;
            default:
                Console.WriteLine("\n❌ Erro: Código de cargo inexistente.");
                salarioFinal = 0;
                break;
        }

        Console.Clear();
        Console.WriteLine("╔════════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                    ✅ HOLERITE RESUMIDO                       ║");
        Console.WriteLine("╠════════════════════════════════════════════════════════════════╣");
        Console.WriteLine($"║ Funcionário: {nomeFuncionario}");
        Console.WriteLine($"║ Cargo: {nomeCargo}");
        Console.WriteLine($"║ Salário Base: R$ {salarioBase:F2}");
        Console.WriteLine($"║ Salário Final: R$ {salarioFinal:F2}");
        Console.WriteLine("╚════════════════════════════════════════════════════════════════╝");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    // ==================== LOOPS WHILE ====================
    static void SomaMenor20()
    {
        Console.WriteLine("📌 SOMA DE NÚMEROS MENORES QUE 20");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int valor;
        int soma = 0;

        Console.Write("Informe um valor inicial: ");
        valor = int.Parse(Console.ReadLine());

        while (valor != 0)
        {
            if (valor < 20)
            {
                soma += valor;
            }
            Console.Write("Informe outro valor (0 para sair): ");
            valor = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"\n✅ A soma dos números menores que 20 é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MediaIdades()
    {
        Console.WriteLine("📌 MÉDIA DE IDADES");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int idade;
        double media;
        int soma = 0, qtde = 0;

        Console.Write("Informe uma idade: ");
        idade = int.Parse(Console.ReadLine());

        while (idade >= 0)
        {
            soma += idade;
            qtde++;
            Console.Write("Informe outra idade (negativa para sair): ");
            idade = int.Parse(Console.ReadLine());
        }

        media = (qtde > 0) ? soma / (double)qtde : 0;

        Console.WriteLine($"\n✅ A média de todas as idades é: {media:F2}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorSenha()
    {
        Console.WriteLine("📌 VALIDADOR DE SENHA");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int senha = 1234;
        int senhaInformada;

        Console.Write("Informe a senha: ");
        senhaInformada = int.Parse(Console.ReadLine());

        while (senhaInformada != senha)
        {
            Console.WriteLine("❌ Senha incorreta, tente novamente:");
            senhaInformada = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n✅ Senha correta, acesso liberado!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MaiorNumero()
    {
        Console.WriteLine("📌 MAIOR NÚMERO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int numero, maior;

        Console.Write("Informe um número para começar: ");
        numero = int.Parse(Console.ReadLine());
        maior = numero;

        while (numero >= 0)
        {
            Console.Write("Informe outro número (NEGATIVO PARA SAIR): ");
            numero = int.Parse(Console.ReadLine());

            if (numero > maior)
            {
                maior = numero;
            }
        }

        Console.WriteLine($"\n✅ O maior número digitado é: {maior}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ValidadorNotas()
    {
        Console.WriteLine("📌 VALIDADOR DE NOTAS (0-10)");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int nota;

        do
        {
            Console.Write("Digite uma nota (0 a 10): ");
            nota = int.Parse(Console.ReadLine());
            if (nota < 0 || nota > 10)
            {
                Console.WriteLine("❌ Nota inválida. Tente novamente.");
            }
        } while (nota < 0 || nota > 10);

        Console.WriteLine($"\n✅ Nota válida: {nota}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void MenuInterativoWhile()
    {
        Console.WriteLine("📌 MENU INTERATIVO");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        int opcao = 1;
        int anoAtual = 2026;

        while (opcao != 3)
        {
            Console.WriteLine("\n1- Dizer Olá");
            Console.WriteLine("2- Mostrar Ano");
            Console.WriteLine("3- Sair");
            Console.Write("\nDigite a opção desejada: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\n✅ Olá!");
                    break;
                case 2:
                    Console.WriteLine($"\n✅ O ano atual é {anoAtual}");
                    break;
                case 3:
                    Console.WriteLine("\n✅ Encerrando...");
                    break;
                default:
                    Console.WriteLine("\n❌ Opção inválida, tente novamente.");
                    break;
            }
        }

        Console.WriteLine("✅ Programa encerrado. Até mais!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ContagemRegressiva()
    {
        Console.WriteLine("📌 CONTAGEM REGRESSIVA COM FOGUETE");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.Write("Informe o número para iniciar a contagem: ");
        int numero = int.Parse(Console.ReadLine());

        while (numero >= 0)
        {
            Console.WriteLine($"{numero}");
            Console.Beep(165, 10000);
            Thread.Sleep(1000);
            numero--;
        }

        Console.WriteLine("\n🚀 FOGUETE LANÇADO!");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void SomadorAcumulador()
    {
        Console.WriteLine("📌 SOMADOR COM ACUMULADOR");
        Console.WriteLine("════════════════════════════════════════════════════════════════");
        Console.WriteLine("Digite números para somar (0 para parar):");
        
        int soma = 0;
        int numero;

        do
        {
            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());
            soma += numero;
        } while (numero != 0);

        Console.WriteLine($"\n✅ A soma total é: {soma}");
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}


/*


using System;

class Program
{
    static void Main(string[] args)
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                      MENU DE EXERCÍCIOS COM WHILE E DO-WHILE              ║");
            Console.WriteLine("╠════════════════════════════════════════════════════════════════════════════╣");
            Console.WriteLine("║  1 - Contagem Crescente Simples                                            ║");
            Console.WriteLine("║  2 - Contagem Regressiva                                                   ║");
            Console.WriteLine("║  3 - Exibição de Números Pares                                             ║");
            Console.WriteLine("║  4 - Exibição de Números Ímpares                                            ║");
            Console.WriteLine("║  5 - Somatório de Intervalo Fixo                                            ║");
            Console.WriteLine("║  6 - Gerador de Tabuada Específica                                         ║");
            Console.WriteLine("║  7 - Cálculo de Quadrados                                                  ║");
            Console.WriteLine("║  8 - Parada por Condição (Sentinela Zero)                                  ║");
            Console.WriteLine("║  9 - Filtro de Múltiplos                                                   ║");
            Console.WriteLine("║ 10 - Cálculo Estatístico de Fatorial Fixo                                   ║");
            Console.WriteLine("║ 11 - Repetidor de Mensagem Customizada                                      ║");
            Console.WriteLine("║ 12 - Potências de Base 2                                                    ║");
            Console.WriteLine("║ 13 - Contador de Ocorrências Negativas                                      ║");
            Console.WriteLine("║ 14 - Acumulador Dinâmico de Entradas                                        ║");
            Console.WriteLine("║ 15 - Média Aritmética Simples                                               ║");
            Console.WriteLine("║ 16 - Contagem Progressiva Obrigatória                                        ║");
            Console.WriteLine("║ 17 - Contagem Regressiva Pós-Testada                                        ║");
            Console.WriteLine("║ 18 - Validação de Confirmação Binária                                       ║");
            Console.WriteLine("║ 19 - Autenticação por Senha Numérica                                        ║");
            Console.WriteLine("║ 20 - Saltos de Escala Numérica                                              ║");
            Console.WriteLine("║ 21 - Acumulador Condicional com Flag Negativo                               ║");
            Console.WriteLine("║ 22 - Menu Interativo de Opções Teóricas                                     ║");
            Console.WriteLine("║ 23 - Filtro de Idade Consistente                                            ║");
            Console.WriteLine("║ 24 - Sequência com Incremento Customizado                                    ║");
            Console.WriteLine("║ 25 - Multiplicação Progressiva por Limite                                    ║");
            Console.WriteLine("║ 26 - Classificador de Paridade Contínuo                                      ║");
            Console.WriteLine("║ 27 - Simulador de Entrada de Texto Flag                                      ║");
            Console.WriteLine("║ 28 - Média Condicional Calculada                                             ║");
            Console.WriteLine("║ 29 - Impressão de Caracteres Repetidos                                      ║");
            Console.WriteLine("║ 30 - Exibição Limitada Dinamicamente                                         ║");
            Console.WriteLine("║ 31 - Validação Acadêmica de Notas                                           ║");
            Console.WriteLine("║ 32 - Consistência de Estado Civil                                            ║");
            Console.WriteLine("║ 33 - Bloqueio de Segurança por Tentativas                                    ║");
            Console.WriteLine("║ 34 - Identificador de Extremos Numéricos                                     ║");
            Console.WriteLine("║ 35 - Contador de Paridade em Lote                                            ║");
            Console.WriteLine("║ 36 - Verificador Matemático de Primo                                         ║");
            Console.WriteLine("║ 37 - Série Numérica de Fibonacci                                             ║");
            Console.WriteLine("║ 38 - Jogo de Adivinhação com Dicas                                          ║");
            Console.WriteLine("║ 39 - Média Ponderada com Parada por Matrícula                                ║");
            Console.WriteLine("║ 40 - Simulador de Saque Eletrônico (Subtrações)                             ║");
            Console.WriteLine("║ 41 - Tabela de Conversão Térmica Repetitiva                                  ║");
            Console.WriteLine("║ 42 - Contador de Caracteres por Sentinela                                    ║");
            Console.WriteLine("║ 43 - Soma dos Dígitos de um Inteiro                                          ║");
            Console.WriteLine("║ 44 - Identificador de Números Perfeitos                                      ║");
            Console.WriteLine("║ 45 - Inversor Numérico Matemático                                            ║");
            Console.WriteLine("║ 46 - Simulador de Cronômetro Regressivo                                      ║");
            Console.WriteLine("║ 47 - Censo Demográfico Local                                                  ║");
            Console.WriteLine("║ 48 - Validação de Cadastro de Produto                                        ║");
            Console.WriteLine("║ 49 - Cálculo de Potenciação Manual                                           ║");
            Console.WriteLine("║ 50 - Máximo Divisor Comum (Algoritmo de Euclides)                          ║");
            Console.WriteLine("║ 51 - Simulação de Crescimento Populacional                                    ║");
            Console.WriteLine("║ 52 - Urna Eletrônica Simulada                                                ║");
            Console.WriteLine("║ 53 - Cálculo de Série Harmônica                                              ║");
            Console.WriteLine("║ 54 - Série Matemática com Sinais Alternados                                  ║");
            Console.WriteLine("║ 55 - Fechamento de Caixa de Vendas                                            ║");
            Console.WriteLine("║ 56 - Jogo de Caça ao Alvo Coordenado                                         ║");
            Console.WriteLine("║ 57 - Análise de Palíndromo Textual                                           ║");
            Console.WriteLine("║ 58 - Analisador de Conjunto de Dados Avançado                                ║");
            Console.WriteLine("║ 59 - Simulador Financeiro de Investimento                                     ║");
            Console.WriteLine("║ 60 - Validador Simplificado de Tamanho de CPF                                ║");
            Console.WriteLine("║ 61 - Controle e Alerta de Estoque Crítico                                    ║");
            Console.WriteLine("║ 62 - Algoritmo de Criptografia (Cifra de César Básica)                      ║");
            Console.WriteLine("║ 63 - Tabuada Completa Matrizada (Laços Aninhados)                           ║");
            Console.WriteLine("║ 64 - Renderizador de Padrões Geométricos (Triângulo)                        ║");
            Console.WriteLine("║ 65 - Tarifador Comercial de Estacionamento Rotativo                          ║");
            Console.WriteLine("║ 66 - Calculadora Científica Modular Iterativa                                 ║");
            Console.WriteLine("║ 67 - Simulador de Corrida de Personagens Virtuais                           ║");
            Console.WriteLine("║  0 - Sair                                                                  ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
            Console.Write("\nDigite a opção desejada: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
                opcao = -1;

            Console.Clear();

            switch (opcao)
            {
                // ==================== CASO 1 ====================
                case 1:
                    // Contagem Crescente Simples
                    int i1 = 1;
                    while (i1 <= 10)
                    {
                        Console.WriteLine(i1);
                        i1++;
                    }
                    break;

                // ==================== CASO 2 ====================
                case 2:
                    // Contagem Regressiva
                    int i2 = 10;
                    while (i2 >= 1)
                    {
                        Console.WriteLine(i2);
                        i2--;
                    }
                    Console.WriteLine("Encerramento!");
                    break;

                // ==================== CASO 3 ====================
                case 3:
                    // Exibição de Números Pares
                    int i3 = 1;
                    while (i3 <= 20)
                    {
                        if (i3 % 2 == 0)
                            Console.WriteLine(i3);
                        i3++;
                    }
                    break;

                // ==================== CASO 4 ====================
                case 4:
                    // Exibição de Números Ímpares
                    int i4 = 1;
                    while (i4 <= 20)
                    {
                        if (i4 % 2 != 0)
                            Console.WriteLine(i4);
                        i4++;
                    }
                    break;

                // ==================== CASO 5 ====================
                case 5:
                    // Somatório de Intervalo Fixo
                    int soma5 = 0;
                    int i5 = 1;
                    while (i5 <= 50)
                    {
                        soma5 += i5;
                        i5++;
                    }
                    Console.WriteLine($"Soma: {soma5}");
                    break;

                // ==================== CASO 6 ====================
                case 6:
                    // Gerador de Tabuada Específica
                    Console.Write("Digite um número: ");
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    int j6 = 1;
                    while (j6 <= 10)
                    {
                        Console.WriteLine($"{num6} x {j6} = {num6 * j6}");
                        j6++;
                    }
                    break;

                // ==================== CASO 7 ====================
                case 7:
                    // Cálculo de Quadrados
                    int i7 = 1;
                    while (i7 <= 10)
                    {
                        Console.WriteLine($"{i7}² = {i7 * i7}");
                        i7++;
                    }
                    break;

                // ==================== CASO 8 ====================
                case 8:
                    // Parada por Condição (Sentinela Zero)
                    int num8;
                    do
                    {
                        Console.Write("Digite um número (0 para sair): ");
                        num8 = Convert.ToInt32(Console.ReadLine());
                    } while (num8 != 0);
                    break;

                // ==================== CASO 9 ====================
                case 9:
                    // Filtro de Múltiplos
                    int i9 = 1;
                    while (i9 <= 100)
                    {
                        if (i9 % 5 == 0)
                            Console.WriteLine(i9);
                        i9++;
                    }
                    break;

                // ==================== CASO 10 ====================
                case 10:
                    // Cálculo Estatístico de Fatorial Fixo
                    int fatorial10 = 5; // Exemplo: 5!
                    int resultado10 = 1;
                    int cont10 = 1;
                    while (cont10 <= fatorial10)
                    {
                        resultado10 *= cont10;
                        cont10++;
                    }
                    Console.WriteLine($"Fatorial de {fatorial10}! = {resultado10}");
                    break;

                // ==================== CASO 11 ====================
                case 11:
                    // Repetidor de Mensagem Customizada
                    Console.Write("Digite uma mensagem: ");
                    string mensagem11 = Console.ReadLine();
                    Console.Write("Quantas vezes repetir? ");
                    int n11 = Convert.ToInt32(Console.ReadLine());
                    int cont11 = 0;
                    while (cont11 < n11)
                    {
                        Console.WriteLine(mensagem11);
                        cont11++;
                    }
                    break;

                // ==================== CASO 12 ====================
                case 12:
                    // Potências de Base 2
                    int pot2 = 1;
                    while (pot2 < 1000)
                    {
                        Console.WriteLine(pot2);
                        pot2 *= 2;
                    }
                    break;

                // ==================== CASO 13 ====================
                case 13:
                    // Contador de Ocorrências Negativas
                    int num13;
                    int negativos13 = 0;
                    do
                    {
                        Console.Write("Digite um número (0 para sair): ");
                        num13 = Convert.ToInt32(Console.ReadLine());
                        if (num13 < 0)
                            negativos13++;
                    } while (num13 != 0);
                    Console.WriteLine($"Números negativos digitados: {negativos13}");
                    break;

                // ==================== CASO 14 ====================
                case 14:
                    // Acumulador Dinâmico de Entradas
                    double soma14 = 0;
                    for (int i14 = 1; i14 <= 10; i14++)
                    {
                        Console.Write($"Digite o {i14}º número: ");
                        double num14 = Convert.ToDouble(Console.ReadLine());
                        soma14 += num14;
                        Console.WriteLine($"Soma acumulada: {soma14}");
                    }
                    break;

                // ==================== CASO 15 ====================
                case 15:
                    // Média Aritmética Simples
                    double soma15 = 0;
                    for (int i15 = 1; i15 <= 5; i15++)
                    {
                        Console.Write($"Digite a {i15}ª nota: ");
                        double nota15 = Convert.ToDouble(Console.ReadLine());
                        soma15 += nota15;
                    }
                    Console.WriteLine($"Média: {soma15 / 5}");
                    break;

                // ==================== CASO 16 ====================
                case 16:
                    // Contagem Progressiva Obrigatória
                    int i16 = 1;
                    do
                    {
                        Console.WriteLine(i16);
                        i16++;
                    } while (i16 <= 10);
                    break;

                // ==================== CASO 17 ====================
                case 17:
                    // Contagem Regressiva Pós-Testada
                    int i17 = 5;
                    do
                    {
                        Console.WriteLine(i17);
                        i17--;
                    } while (i17 > 0);
                    break;

                // ==================== CASO 18 ====================
                case 18:
                    // Validação de Confirmação Binária
                    char conf18;
                    do
                    {
                        Console.Write("Digite 'S' para Sim ou 'N' para Não: ");
                        conf18 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    } while (conf18 != 'S' && conf18 != 'N');
                    break;

                // ==================== CASO 19 ====================
                case 19:
                    // Autenticação por Senha Numérica
                    int senha19;
                    do
                    {
                        Console.Write("Digite a senha: ");
                        senha19 = Convert.ToInt32(Console.ReadLine());
                    } while (senha19 != 1234);
                    Console.WriteLine("Acesso concedido.");
                    break;

                // ==================== CASO 20 ====================
                case 20:
                    // Saltos de Escala Numérica
                    int i20 = 0;
                    do
                    {
                        Console.WriteLine(i20);
                        i20 += 10;
                    } while (i20 <= 100);
                    break;

                // ==================== CASO 21 ====================
                case 21:
                    // Acumulador Condicional com Flag Negativo
                    int num21;
                    int soma21 = 0;
                    do
                    {
                        Console.Write("Digite um número: ");
                        num21 = Convert.ToInt32(Console.ReadLine());
                        soma21 += num21;
                    } while (num21 >= 0);
                    Console.WriteLine($"Soma total: {soma21}");
                    break;

                // ==================== CASO 22 ====================
                case 22:
                    // Menu Interativo de Opções Teóricas
                    int escolha22;
                    do
                    {
                        Console.WriteLine("1 - Cadastrar");
                        Console.WriteLine("2 - Listar");
                        Console.WriteLine("0 - Sair");
                        Console.Write("Escolha uma opção: ");
                        escolha22 = Convert.ToInt32(Console.ReadLine());
                    } while (escolha22 != 0);
                    break;

                // ==================== CASO 23 ====================
                case 23:
                    // Filtro de Idade Consistente
                    int idade23;
                    do
                    {
                        Console.Write("Digite sua idade: ");
                        idade23 = Convert.ToInt32(Console.ReadLine());
                    } while (idade23 <= 0);
                    break;

                // ==================== CASO 24 ====================
                case 24:
                    // Sequência com Incremento Customizado
                    int num24 = 1;
                    do
                    {
                        Console.WriteLine(num24);
                        num24 += 3;
                    } while (num24 <= 30);
                    break;

                // ==================== CASO 25 ====================
                case 25:
                    // Multiplicação Progressiva por Limite
                    Console.Write("Digite um número: ");
                    int num25 = Convert.ToInt32(Console.ReadLine());
                    while (num25 <= 500)
                    {
                        Console.WriteLine(num25);
                        num25 *= 2;
                    }
                    break;

                // ==================== CASO 26 ====================
                case 26:
                    // Classificador de Paridade Contínuo
                    int num26;
                    do
                    {
                        Console.Write("Digite um número: ");
                        num26 = Convert.ToInt32(Console.ReadLine());
                        if (num26 >= 0)
                        {
                            if (num26 % 2 == 0)
                                Console.WriteLine($"{num26} é par.");
                            else
                                Console.WriteLine($"{num26} é ímpar.");
                        }
                    } while (num26 >= 0);
                    break;

                // ==================== CASO 27 ====================
                case 27:
                    // Simulador de Entrada de Texto Flag
                    string palavra27;
                    int totalPalavras27 = 0;
                    do
                    {
                        Console.Write("Digite uma palavra (parar para encerrar): ");
                        palavra27 = Console.ReadLine();
                        if (palavra27 != "parar")
                            totalPalavras27++;
                    } while (palavra27 != "parar");
                    Console.WriteLine($"Total de palavras inseridas: {totalPalavras27}");
                    break;

                // ==================== CASO 28 ====================
                case 28:
                    // Média Condicional Calculada
                    char continuar28;
                    do
                    {
                        Console.Write("Digite a 1ª nota: ");
                        double nota1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite a 2ª nota: ");
                        double nota2 = Convert.ToDouble(Console.ReadLine());
                        double media28 = (nota1 + nota2) / 2;
                        Console.WriteLine($"Média: {media28}");
                        Console.Write("Deseja calcular a nota de outro aluno? (S/N): ");
                        continuar28 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    } while (continuar28 == 'S');
                    break;

                // ==================== CASO 29 ====================
                case 29:
                    // Impressão de Caracteres Repetidos
                    Console.Write("Digite um número: ");
                    int n29 = Convert.ToInt32(Console.ReadLine());
                    if (n29 >= 1)
                    {
                        for (int i29 = 0; i29 < n29; i29++)
                            Console.Write("*");
                        Console.WriteLine();
                    }
                    break;

                // ==================== CASO 30 ====================
                case 30:
                    // Exibição Limitada Dinamicamente
                    Console.Write("Digite um número inteiro limite: ");
                    int limite30 = Convert.ToInt32(Console.ReadLine());
                    int i30 = 0;
                    do
                    {
                        if (i30 % 2 == 0)
                            Console.WriteLine(i30);
                        i30++;
                    } while (i30 <= limite30);
                    break;

                // ==================== CASO 31 ====================
                case 31:
                    // Validação Acadêmica de Notas
                    double nota31;
                    do
                    {
                        Console.Write("Digite uma nota (0 a 10): ");
                        nota31 = Convert.ToDouble(Console.ReadLine());
                    } while (nota31 < 0.0 || nota31 > 10.0);
                    break;

                // ==================== CASO 32 ====================
                case 32:
                    // Consistência de Estado Civil
                    char estadoCivil32;
                    do
                    {
                        Console.Write("Digite seu estado civil (S, C, V, D): ");
                        estadoCivil32 = Console.ReadKey().KeyChar;
                        Console.WriteLine();
                    } while (estadoCivil32 != 'S' && estadoCivil32 != 'C' && estadoCivil32 != 'V' && estadoCivil32 != 'D');
                    break;

                // ==================== CASO 33 ====================
                case 33:
                    // Bloqueio de Segurança por Tentativas
                    int tentativas33 = 0;
                    int senha33;
                    do
                    {
                        Console.Write("Digite a senha: ");
                        senha33 = Convert.ToInt32(Console.ReadLine());
                        tentativas33++;
                    } while (senha33 != 1234 && tentativas33 < 3);
                    if (tentativas33 == 3)
                        Console.WriteLine("Acesso bloqueado.");
                    else
                        Console.WriteLine("Acesso concedido.");
                    break;

                // ==================== CASO 34 ====================
                case 34:
                    // Identificador de Extremos Numéricos
                    int num34;
                    int maior34 = int.MinValue, menor34 = int.MaxValue;
                    do
                    {
                        Console.Write("Digite um número (0 para sair): ");
                        num34 = Convert.ToInt32(Console.ReadLine());
                        if (num34 != 0)
                        {
                            if (num34 > maior34) maior34 = num34;
                            if (num34 < menor34) menor34 = num34;
                        }
                    } while (num34 != 0);
                    Console.WriteLine($"Maior: {maior34}, Menor: {menor34}");
                    break;

                // ==================== CASO 35 ====================
                case 35:
                    // Contador de Paridade em Lote
                    int num35;
                    int pares35 = 0, impares35 = 0;
                    do
                    {
                        Console.Write("Digite um número (999 para sair): ");
                        num35 = Convert.ToInt32(Console.ReadLine());
                        if (num35 != 999)
                        {
                            if (num35 % 2 == 0) pares35++;
                            else impares35++;
                        }
                    } while (num35 != 999);
                    Console.WriteLine($"Pares: {pares35}, Ímpares: {impares35}");
                    break;

                // ==================== CASO 36 ====================
                case 36:
                    // Verificador Matemático de Primo
                    Console.Write("Digite um número inteiro positivo: ");
                    int primo36 = Convert.ToInt32(Console.ReadLine());
                    bool ehPrimo36 = true;
                    for (int j36 = 2; j36 <= Math.Sqrt(primo36); j36++)
                    {
                        if (primo36 % j36 == 0)
                        {
                            ehPrimo36 = false;
                            break;
                        }
                    }
                    Console.WriteLine(ehPrimo36 ? $"{primo36} é primo." : $"{primo36} não é primo.");
                    break;

                // ==================== CASO 37 ====================
                case 37:
                    // Série Numérica de Fibonacci
                    Console.Write("Digite um valor inteiro N: ");
                    int n37 = Convert.ToInt32(Console.ReadLine());
                    int a37 = 0, b37 = 1;
                    Console.WriteLine("Fibonacci:");
                    for (int k37 = 0; k37 < n37; k37++)
                    {
                        Console.WriteLine(a37);
                        int temp = a37;
                        a37 = b37;
                        b37 = temp + b37;
                    }
                    break;

                // ==================== CASO 38 ====================
                case 38:
                    // Jogo de Adivinhação com Dicas
                    Random rnd38 = new Random();
                    int numeroSecreto38 = rnd38.Next(1, 101);
                    int palpite38;
                    do
                    {
                        Console.Write("Adivinhe o número (1 a 100): ");
                        palpite38 = Convert.ToInt32(Console.ReadLine());
                        if (palpite38 > numeroSecreto38) Console.WriteLine("Menor!");
                        else if (palpite38 < numeroSecreto38) Console.WriteLine("Maior!");
                    } while (palpite38 != numeroSecreto38);
                    Console.WriteLine("Parabéns! Você acertou!");
                    break;

                // ==================== CASO 39 ====================
                case 39:
                    // Média Ponderada com Parada por Matrícula
                    int matricula39;
                    do
                    {
                        Console.Write("Matrícula (0 para sair): ");
                        matricula39 = Convert.ToInt32(Console.ReadLine());

                        if (matricula39 != 0)
                        {
                            Console.Write("Nota 1: ");
                            double nota1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Nota 2: ");
                            double nota2 = Convert.ToDouble(Console.ReadLine());
                            double media39 = ((nota1 * 2) + (nota2 * 3)) / 5;
                            Console.WriteLine($"Média: {media39:F2}");
                        }

                    } while (matricula39 != 0);
                    break;

                // ==================== CASO 40 ====================
                case 40:
                    // Simulador de Saque Eletrônico (Subtrações)
                    Console.Write("Valor do saque: ");
                    int saque40 = Convert.ToInt32(Console.ReadLine());

                    int ced50 = 0, ced20 = 0, ced10 = 0;

                    while (saque40 >= 50)
                    {
                        ced50++;
                        saque40 -= 50;
                    }

                    while (saque40 >= 20)
                    {
                        ced20++;
                        saque40 -= 20;
                    }

                    while (saque40 >= 10)
                    {
                        ced10++;
                        saque40 -= 10;
                    }

                    Console.WriteLine($"Notas de 50: {ced50}");
                    Console.WriteLine($"Notas de 20: {ced20}");
                    Console.WriteLine($"Notas de 10: {ced10}");
                    break;

                // ==================== CASO 41 ====================
                case 41:
                    // Tabela de Conversão Térmica Repetitiva
                    double celsius41;
                    do
                    {
                        Console.Write("Temperatura (-999 para sair): ");
                        celsius41 = Convert.ToDouble(Console.ReadLine());

                        if (celsius41 != -999)
                        {
                            double fahrenheit = (celsius41 * 9 / 5) + 32;
                            Console.WriteLine($"Fahrenheit: {fahrenheit:F2}");
                        }

                    } while (celsius41 != -999);
                    break;

                // ==================== CASO 42 ====================
                case 42:
                    // Contador de Caracteres por Sentinela
                    string texto42;
                    do
                    {
                        Console.Write("Digite uma frase (sair para encerrar): ");
                        texto42 = Console.ReadLine();
                        if (texto42.ToLower() != "sair")
                            Console.WriteLine($"Quantidade de caracteres: {texto42.Length}");

                    } while (texto42.ToLower() != "sair");
                    break;

                // ==================== CASO 43 ====================
                case 43:
                    // Soma dos Dígitos de um Inteiro
                    Console.Write("Digite um número inteiro: ");
                    int numero43 = Convert.ToInt32(Console.ReadLine());
                    int soma43 = 0;

                    while (numero43 > 0)
                    {
                        soma43 += numero43 % 10;
                        numero43 /= 10;
                    }

                    Console.WriteLine($"Soma dos dígitos: {soma43}");
                    break;

                // ==================== CASO 44 ====================
                case 44:
                    // Identificador de Números Perfeitos
                    Console.Write("Digite um número: ");
                    int numero44 = Convert.ToInt32(Console.ReadLine());
                    int somaDivisores44 = 0;

                    for (int divisores44 = 1; divisores44 < numero44; divisores44++)
                    {
                        if (numero44 % divisores44 == 0)
                            somaDivisores44 += divisores44;
                    }

                    Console.WriteLine(somaDivisores44 == numero44 ? "Número perfeito." : "Número não perfeito.");
                    break;

                // ==================== CASO 45 ====================
                case 45:
                    // Inversor Numérico Matemático
                    Console.Write("Digite um número: ");
                    int numero45 = Convert.ToInt32(Console.ReadLine());
                    int invertido45 = 0;

                    while (numero45 > 0)
                    {
                        invertido45 = invertido45 * 10 + (numero45 % 10);
                        numero45 /= 10;
                    }

                    Console.WriteLine($"Invertido: {invertido45}");
                    break;

                // ==================== CASO 46 ====================
                case 46:
                    // Simulador de Cronômetro Regressivo
                    Console.Write("Minutos: ");
                    int minutos46 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Segundos: ");
                    int segundos46 = Convert.ToInt32(Console.ReadLine());

                    while (minutos46 >= 0)
                    {
                        Console.WriteLine($"{minutos46:D2}:{segundos46:D2}");

                        if (minutos46 == 0 && segundos46 == 0)
                            break;

                        segundos46--;

                        if (segundos46 < 0)
                        {
                            segundos46 = 59;
                            minutos46--;
                        }
                    }
                    break;

                // ==================== CASO 47 ====================
                case 47:
                    // Censo Demográfico Local
                    double salario47;
                    double somaSalario47 = 0;
                    int somaFilhos47 = 0;
                    int qtd47 = 0;

                    do
                    {
                        Console.Write("Salário (negativo encerra): ");
                        salario47 = Convert.ToDouble(Console.ReadLine());

                        if (salario47 >= 0)
                        {
                            Console.Write("Filhos: ");
                            int filhos47 = Convert.ToInt32(Console.ReadLine());

                            somaSalario47 += salario47;
                            somaFilhos47 += filhos47;
                            qtd47++;
                        }

                    } while (salario47 >= 0);

                    if (qtd47 > 0)
                    {
                        Console.WriteLine($"Média salarial: {somaSalario47 / qtd47:F2}");
                        Console.WriteLine($"Média de filhos: {(double)somaFilhos47 / qtd47:F2}");
                    }
                    break;

                // ==================== CASO 48 ====================
                case 48:
                    // Validação de Cadastro de Produto
                    string nome48;
                    double preco48;

                    do
                    {
                        Console.Write("Nome (mínimo 3 caracteres): ");
                        nome48 = Console.ReadLine();

                    } while (nome48.Length < 3);

                    do
                    {
                        Console.Write("Preço (maior que zero): ");
                        preco48 = Convert.ToDouble(Console.ReadLine());

                    } while (preco48 <= 0);

                    Console.WriteLine("Produto cadastrado.");
                    break;

                // ==================== CASO 49 ====================
                case 49:
                    // Cálculo de Potenciação Manual
                    Console.Write("Base: ");
                    int base49 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Expoente: ");
                    int expoente49 = Convert.ToInt32(Console.ReadLine());

                    int resultado49 = 1;

                    for (int cont49 = 1; cont49 <= expoente49; cont49++)
                    {
                        resultado49 *= base49;
                    }

                    Console.WriteLine($"Resultado: {resultado49}");
                    break;

                // ==================== CASO 50 ====================
                case 50:
                    // Máximo Divisor Comum (Algoritmo de Euclides)
                    Console.Write("Número A: ");
                    int a50 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Número B: ");
                    int b50 = Convert.ToInt32(Console.ReadLine());

                    while (b50 != 0)
                    {
                        int resto50 = a50 % b50;
                        a50 = b50;
                        b50 = resto50;
                    }

                    Console.WriteLine($"MDC = {a50}");
                    break;

                // ==================== CASO 51 ====================
                case 51:
                    // Simulação de Crescimento Populacional
                    double paisA = 80000;
                    double paisB = 200000;
                    int anos51 = 0;

                    while (paisA < paisB)
                    {
                        paisA += paisA * 0.03;
                        paisB += paisB * 0.015;
                        anos51++;
                    }

                    Console.WriteLine($"Serão necessários {anos51} anos.");
                    break;

                // ==================== CASO 52 ====================
                case 52:
                    // Urna Eletrônica Simulada
                    int voto52;
                    int[] candidatos = new int[3];
                    int nulos = 0, brancos = 0;

                    do
                    {
                        Console.WriteLine("1 - Candidato 1");
                        Console.WriteLine("2 - Candidato 2");
                        Console.WriteLine("3 - Candidato 3");
                        Console.WriteLine("4 - Nulo");
                        Console.WriteLine("5 - Branco");
                        Console.WriteLine("0 - Encerrar");
                        Console.Write("Vote: ");
                        voto52 = Convert.ToInt32(Console.ReadLine());

                        if (voto52 >= 1 && voto52 <= 3)
                            candidatos[voto52 - 1]++;
                        else if (voto52 == 4)
                            nulos++;
                        else if (voto52 == 5)
                            brancos++;

                    } while (voto52 != 0);

                    Console.WriteLine($"Candidato 1: {candidatos[0]}");
                    Console.WriteLine($"Candidato 2: {candidatos[1]}");
                    Console.WriteLine($"Candidato 3: {candidatos[2]}");
                    int totalVotos52 = candidatos[0] + candidatos[1] + candidatos[2] + nulos + brancos;
                    if (totalVotos52 > 0)
                    {
                        Console.WriteLine($"% Nulos: {(double)nulos / totalVotos52 * 100:F2}%");
                        Console.WriteLine($"% Brancos: {(double)brancos / totalVotos52 * 100:F2}%");
                    }
                    break;

                // ==================== CASO 53 ====================
                case 53:
                    // Cálculo de Série Harmônica
                    Console.Write("Digite um valor inteiro positivo N: ");
                    int n53 = Convert.ToInt32(Console.ReadLine());
                    double soma53 = 0;

                    for (int j53 = 1; j53 <= n53; j53++)
                    {
                        soma53 += 1.0 / j53;
                    }

                    Console.WriteLine($"Série Harmônica: {soma53:F4}");
                    break;

                // ==================== CASO 54 ====================
                case 54:
                    // Série Matemática com Sinais Alternados
                    Console.Write("Digite N: ");
                    int n54 = Convert.ToInt32(Console.ReadLine());
                    double soma54 = 0;
                    for (int k54 = 1; k54 <= n54; k54++)
                    {
                        if (k54 % 2 == 0)
                            soma54 -= (double)k54 / (2 * k54 - 1);
                        else
                            soma54 += (double)k54 / (2 * k54 - 1);
                    }

                    Console.WriteLine($"Resultado: {soma54:F4}");
                    break;

              // ==================== CASO 55 ====================
case 55:
    // Fechamento de Caixa de Vendas
    double total55 = 0;
    while (true)
    {
        Console.Write("Preço do produto: ");
        double preco55 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Quantidade (0 encerra): ");
        int qtd55 = Convert.ToInt32(Console.ReadLine());

        if (qtd55 == 0)
            break;

        total55 += preco55 * qtd55;
    }

    if (total55 > 500)
        total55 *= 0.90;

    Console.WriteLine($"Total a pagar: R$ {total55:F2}");
    break;

// ==================== CASO 56 ====================
case 56:
    // Jogo de Caça ao Alvo Coordenado
    int alvoX = 7;
    int alvoY = 12;
    int x56, y56;

    do
    {
        Console.Write("Digite a coordenada X: ");
        x56 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite a coordenada Y: ");
        y56 = Convert.ToInt32(Console.ReadLine());

        if (x56 < alvoX) Console.WriteLine("Mais a Leste");
        else if (x56 > alvoX) Console.WriteLine("Mais a Oeste");

        if (y56 < alvoY) Console.WriteLine("Mais ao Norte");
        else if (y56 > alvoY) Console.WriteLine("Mais ao Sul");

    } while (x56 != alvoX || y56 != alvoY);

    Console.WriteLine("Alvo encontrado!");
    break;

// ==================== CASO 57 ====================
case 57:
    // Análise de Palíndromo Textual
    Console.Write("Digite uma palavra: ");
    string palavra57 = Console.ReadLine().ToLower();

    bool palindromo57 = true;
    int inicio57 = 0;
    int fim57 = palavra57.Length - 1;

    while (inicio57 < fim57)
    {
        if (palavra57[inicio57] != palavra57[fim57])
        {
            palindromo57 = false;
            break;
        }
        inicio57++;
        fim57--;
    }

    Console.WriteLine(palindromo57 ? "É palíndromo." : "Não é palíndromo.");
    break;

// ==================== CASO 58 ====================
case 58:
    // Analisador de Conjunto de Dados Avançado
    int numero58;
    int total58 = 0;
    int impares58 = 0;
    double somaPares58 = 0;
    int qtdPares58 = 0;

    do
    {
        Console.Write("Número (0 encerra): ");
        numero58 = Convert.ToInt32(Console.ReadLine());

        if (numero58 != 0)
        {
            total58++;
            if (numero58 % 2 == 0)
            {
                somaPares58 += numero58;
                qtdPares58++;
            }
            else
            {
                impares58++;
            }
        }

    } while (numero58 != 0);

    if (qtdPares58 > 0)
        Console.WriteLine($"Média dos pares: {somaPares58 / qtdPares58:F2}");

    if (total58 > 0)
        Console.WriteLine($"% Ímpares: {(double)impares58 / total58 * 100:F2}%");
    break;

// ==================== CASO 59 ====================
case 59:
    // Simulador Financeiro de Investimento
    Console.Write("Capital inicial: ");
    double capital59 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Taxa (%): ");
    double taxa59 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Meses: ");
    int meses59 = Convert.ToInt32(Console.ReadLine());

    for (int mes59 = 1; mes59 <= meses59; mes59++)
    {
        capital59 += capital59 * (taxa59 / 100);
        Console.WriteLine($"Mês {mes59}: R$ {capital59:F2}");
    }
    break;

// ==================== CASO 60 ====================
case 60:
    // Validador Simplificado de Tamanho de CPF
    string cpf60;

    do
    {
        Console.Write("Digite um CPF: ");
        cpf60 = Console.ReadLine().Replace(".", "").Replace("-", "");

    } while (cpf60.Length != 11);

    Console.WriteLine("CPF válido.");
    break;

// ==================== CASO 61 ====================
case 61:
    // Controle e Alerta de Estoque Crítico
    Console.Write("Quantidade inicial: ");
    int estoque61 = Convert.ToInt32(Console.ReadLine());
    int inicial61 = estoque61;

    int retirada61;
    do
    {
        Console.Write("Retirada (-1 encerra): ");
        retirada61 = Convert.ToInt32(Console.ReadLine());

        if (retirada61 > 0)
            estoque61 -= retirada61;

        Console.WriteLine($"Estoque: {estoque61}");

        if (estoque61 <= inicial61 * 0.15)
            Console.WriteLine("ALERTA: Estoque crítico!");

    } while (retirada61 != -1 && estoque61 > 0);
    break;

// ==================== CASO 62 ====================
case 62:
    // Algoritmo de Criptografia (Cifra de César Básica)
    Console.Write("Texto: ");
    string texto62 = Console.ReadLine();

    Console.Write("Deslocamento: ");
    int desloc62 = Convert.ToInt32(Console.ReadLine());

    string resultado62 = "";

    foreach (char c in texto62)
    {
        resultado62 += (char)(c + desloc62);
    }

    Console.WriteLine($"Texto cifrado: {resultado62}");
    break;

// ==================== CASO 63 ====================
case 63:
    // Tabuada Completa Matrizada (Laços Aninhados)
    for (int i63 = 1; i63 <= 10; i63++)
    {
        Console.WriteLine($"--- TABUADA DO {i63} ---");
        for (int j63 = 1; j63 <= 10; j63++)
        {
            Console.WriteLine($"{i63} x {j63} = {i63 * j63}");
        }
    }
    break;

// ==================== CASO 64 ====================
case 64:
    // Renderizador de Padrões Geométricos (Triângulo)
    Console.Write("Altura: ");
    int altura64 = Convert.ToInt32(Console.ReadLine());

    for (int linha64 = 1; linha64 <= altura64; linha64++)
    {
        for (int coluna64 = 1; coluna64 <= linha64; coluna64++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    break;

// ==================== CASO 65 ====================
case 65:
    // Tarifador Comercial de Estacionamento Rotativo
    while (true)
    {
        Console.Write("Entrada (minutos, -1 encerra): ");
        int entrada65 = Convert.ToInt32(Console.ReadLine());

        if (entrada65 == -1)
            break;

        Console.Write("Saída: ");
        int saida65 = Convert.ToInt32(Console.ReadLine());

        int tempo65 = saida65 - entrada65;
        int horas65 = (int)Math.Ceiling(tempo65 / 60.0);

        Console.WriteLine($"Valor: R$ {horas65 * 5:F2}");
    }
    break;

// ==================== CASO 66 ====================
case 66:
    // Calculadora Científica Modular Iterativa
    int op66;
    do
    {
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        Console.WriteLine("5 - Potência");
        Console.WriteLine("6 - Fatorial");
        Console.WriteLine("0 - Sair");
        
        Console.Write("Opção: ");
        op66 = Convert.ToInt32(Console.ReadLine());

        if (op66 >= 1 && op66 <= 5)
        {
            Console.Write("A: ");
            double a66 = Convert.ToDouble(Console.ReadLine());

            Console.Write("B: ");
            double b66 = Convert.ToDouble(Console.ReadLine());

            switch (op66)
            {
                case 1: Console.WriteLine($"Resultado: {a66 + b66}"); break;
                case 2: Console.WriteLine($"Resultado: {a66 - b66}"); break;
                case 3: Console.WriteLine($"Resultado: {a66 * b66}"); break;
                case 4: Console.WriteLine($"Resultado: {a66 / b66}"); break;
                case 5: Console.WriteLine($"Resultado: {Math.Pow(a66, b66)}"); break;
            }
        }

        if (op66 == 6)
        {
            Console.Write("Número: ");
            int n66 = Convert.ToInt32(Console.ReadLine());

            long fat66 = 1;
            while (n66 > 1)
            {
                fat66 *= n66;
                n66--;
            }

            Console.WriteLine($"Fatorial: {fat66}");
        }

    } while (op66 != 0);
    break;

// ==================== CASO 67 ====================
case 67:
    // Simulador de Corrida de Personagens Virtuais
    int corredorA = 0;
    int corredorB = 0;
    Random rnd67 = new Random();

    while (corredorA < 100 && corredorB < 100)
    {
        corredorA += rnd67.Next(1, 11);
        corredorB += rnd67.Next(1, 11);

        Console.WriteLine($"Corredor A: {corredorA}m | Corredor B: {corredorB}m");
    }

    if (corredorA >= 100 && corredorB >= 100)
        Console.WriteLine("Empate!");
    else if (corredorA >= 100)
        Console.WriteLine("Corredor A venceu!");
    else
        Console.WriteLine("Corredor B venceu!");

    break;

                case 0:
                    Console.WriteLine("Programa finalizado. Até mais!");
                    break;
            }
        } while (opcao != 0);
    }
}

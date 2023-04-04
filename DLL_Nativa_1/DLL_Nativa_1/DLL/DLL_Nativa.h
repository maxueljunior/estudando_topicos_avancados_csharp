#pragma once

/// <summary>
/// Estrutura utilizada nas fun��es
/// - RecebeEstrutura
/// - EnviaEstrutura
/// </summary>
struct MinhaEstrutura
{
    int valor1;
    double valor2;
    char valor3;
};

/// <summary>
/// Fun��o Soma. Retorna a soma de dois n�meros to tipo double
/// </summary>
/// <param name="a">Par�metro de entrada do tipo double</param>
/// <param name="b">Par�metro de entrada do tipo double</param>
/// <returns>Par�metro de sa�da do tipo double. O n�mero retornado � a soma dos par�metros de entrada</returns>
extern "C" __declspec(dllexport) double Soma(double a, double b);

/// <summary>
/// Fun��o Media. Retorna a m�dia aritm�tica dos n�meros passados no vetor a
/// </summary>
/// <param name="a">Vetor do tipo double. Este vetor contem os n�meros usados para o c�lculo da m�dia</param>
/// <param name="quantidade">N�mero de elementos do vetor a</param>
/// <returns>Par�metro de sa�da do tipo double. Retorna a m�dia aritm�tica de todos os n�meros passados no vetor a</returns>
extern "C" __declspec(dllexport) double Media(double* a, int quantidade);

/// <summary>
/// Fun��o RecebeVetor. Esta fun��o recebe um vetor e o preenche com n�meros crescentes de 0 at� n
/// </summary>
/// <param name="Vetor">Vetor do tipo int que ser� preenchido com n�meros crescentes</param>
/// <param name="Tamanho">N�mero de elementos em Vetor</param>
extern "C" __declspec(dllexport) void RecebeVetor(int* Vetor, int Tamanho);

/// <summary>
/// Fun��o EnviaFrase. Est� fun��o retorna "true" se o par�metro de entrada for a string "EnviaFrase"
/// </summary>
/// <param name="Frase">Pat�metro de entrada do tipo ponteiro de chars. Deve ser terminada em nulo</param>
/// <returns>Retorna "true" se a Frase for "EnviaFrase"</returns>
extern "C" __declspec(dllexport) BOOL EnviaFrase(char* Frase);

/// <summary>
/// Fun��o PegraFrase. Est� fun��o preenche uma string passada como par�metro de entrada
/// </summary>
/// <param name="Frase">Par�metro de entrada do tipo char*. Ser� preenchida com uma franse</param>
/// <param name="Tamanho">Tamanho da string de entrada</param>
extern "C" __declspec(dllexport) void PegaFrase(char* Frase, int Tamanho);

/// <summary>
/// Fun��o RetornaString. Retorna um array de char terminado em nulo com uma frase
/// Chamar LimpaMemoria depois de usar essa fun��o
/// </summary>
/// <returns></returns>
extern "C" __declspec(dllexport) char* RetornaString();

/// <summary>
/// Fun��o RetornaArrayDeBytes. Fun��o que retorna uma array de bytes de 3 posi��es.
/// O primeiro byte ser� 0
/// O segundo byte ser� 1
/// O terceiro byte ser� 2
/// Chamar LimpaMemoria depois de usar essa fun��o
/// </summary>
/// <returns>Array de bytes retornado</returns>
extern "C" __declspec(dllexport) unsigned char * RetornaArrayDeBytes();

/// <summary>
/// Fun��o RecebeEstrutura. Esta fun��o recebe uma estrutura do tipo MinhaEstrutura e a preenche com:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 30
/// </summary>
/// <param name="minhaEstrutura">Estrutura de entrada do tipo MinhaEstrutura</param>
extern "C" __declspec(dllexport) void RecebeEstrutura(struct MinhaEstrutura* minhaEstrutura);

/// <summary>
/// Fun��o EnviaEstrutura. Retorna true se a estrutura de entrada do tipo MinhaEstrutura tiver os seguintes valores:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 'a'
/// </summary>
/// <param name="minhaEstrutura">Par�metro de entrada do tipo minhaEstrutura</param>
/// <returns></returns>
extern "C" __declspec(dllexport) BOOL EnviaEstrutura(struct MinhaEstrutura* minhaEstrutura);

/// <summary>
/// Fun��o RetornaEstrutura. Retorna uma estrutura do tipo MinhaEstrutura com os seguintes valores:
/// - valor1 = 10
/// - valor2 = 20
/// - valor3 = 30
/// Chamar LimpaMemoria depois de usar essa fun��o
/// </summary>
extern "C" __declspec(dllexport) struct MinhaEstrutura* RetornaEstrutura();

/// <summary>
/// Fun��o LimpaMemoria.
/// Deve ser chamada ap�s as fun��es :
/// - RetornaArrayDeBytes
/// - RetornaString
/// - RetornaEstrutura
/// </summary>
extern "C" __declspec(dllexport) void LimpaMemoria();


### **Programação .NET**  
**Professor Ricardo Frohlich da Silva**

---

#### **Unidade 1 - Introdução a programação C#**
- 1.1 Introdução ao C#: Conceitos, Ambiente de Desenvolvimento e Primeiro Programa
- 1.2 Controle de Fluxo e Métodos: Estruturas Condicionais, Repetição e Funções

#### **Unidade 2 - Programação Orientada a Objetos com C#**
- 2.1 Fundamentos de POO: Classes, Objetos, Herança e Encapsulamento
- 2.2 Aplicações de POO: Polimorfismo, Abstração e Relacionamentos entre Classes

#### **Unidade 3 - Construindo Aplicações com .NET Framework**
- 3.1 Estrutura do .NET Framework
- 3.2 Criando Aplicações Básicas com .NET

#### **Unidade 4 - Explorando Frameworks**
- 4.1 Introdução ao ASP.NET Core
- 4.2 Entity Framework

---

### **Objetivos da Disciplina**
- Abertura da disciplina: você já teve contato com lógica de programação? Já ouviu falar sobre POO?
- Fornecer bases sólidas para o desenvolvimento de aplicações utilizando C#, com foco em boas práticas e construção eficiente/escalável.
- Da programação básica até uma aplicação completa com .NET Framework.

---

### **Metodologia de Ensino**
- Aulas expositivas e práticas.
- Exercícios teóricos e práticos, atividades em laboratório e desafios com problemas reais.
- Uso da plataforma Minha UFN para materiais e atividades.
- Metodologias ativas como aprendizagem baseada em projetos.

---

### **Avaliação da Aprendizagem**
- N1 = (Produto de aprendizagem 1 * 0,6) + (Exercícios * 0,4)
- N2 = (Produto de aprendizagem 2 * 0,6) + (Exercícios e trabalhos * 0,4)
- N3 = (Produto de aprendizagem 3 * 0,6) + (Exercícios e trabalhos * 0,4)
- Nota Final = (N1 + N2 + N3) / 3
- Aprovado: Nota Final ≥ 6,0 e frequência ≥ 75%

---

### **C# e .NET**
- **C#**: Linguagem moderna, orientada a objetos, desenvolvida pela Microsoft.
- **.NET**: Framework com biblioteca (FCL) e ambiente de execução (CLR) para múltiplas linguagens (C#, VB.NET, F#).
- Código em C# é compilado em IL (Intermediate Language), executado pelo CLR.
- Oferece recursos como manipulação de arquivos, comunicação de rede e banco de dados.

---

### **Visual Studio**
- IDE da Microsoft para desenvolvimento em múltiplas plataformas (desktop, web, mobile, cloud).  
🔗 [Download do Visual Studio](https://visualstudio.microsoft.com/pt-br/downloads/)

---

### **Comandos de Entrada e Saída**

#### **Saída - `Console.WriteLine()`**
```csharp
static void Main(string[] args)
{
    Console.WriteLine("Eita mundão sô!");
}
```

#### **Tipos de Dados**
- `char letra1 = 'A';`
- `int valor1 = 54;`
- `float valor2 = 43.6778;`
- `double valor3 = 32.45345346;`

---

### **Variáveis**
- Declaração:
  ```csharp
  int x, y, z = 10;
  float a = 3, c = 4.23, d;
  char i, j = 'a';
  ```

---

### **Operadores**
#### **Prioridade**
1. `-` (inversão)
2. `*`, `/`, `%`
3. `+`, `-`

#### **Exemplos**
```csharp
x + 5 * y - 4   // primeiro * depois + e -
(x + 5) * (y - 4) // usa parênteses para definir precedência
```

---

### **Operadores de Incremento/Decremento**
```csharp
int a = 5, b = 10;
a--;    // ou a -= 1;
b++;    // ou b += 1;
a += 5;
b -= 3;
```

---

### **Manipulando Strings**
(*conteúdo visual sem texto adicional específico*)

---

### **Entrada - `Console.ReadLine()`**
- `char letra = char.Parse(Console.ReadLine());`
- `double numero = double.Parse(Console.ReadLine());`

---

#### **Atividade**
- Faça a leitura de dois números `double` e realize as 4 operações matemáticas.
- Apresente os resultados na tela.

---


Fontes:
- O conteúdo foi extraído diretamente do material enviado por você: **[Aula 01 - Programação .NET - Escrita e leitura.pdf]**.
- Visual Studio: https://visualstudio.microsoft.com/pt-br/downloads/  

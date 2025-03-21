
### **Programação .NET**  
**Professor Ricardo Frohlich da Silva**

---

## **Switch-case (Revisão)**

- O `switch` é um comando de **seleção múltipla**.
- Testa sucessivamente o valor de uma **expressão contra constantes** (inteiros ou caracteres).
- **Importante**: só funciona para inteiros e caracteres.
- Diferente do `if`, que pode testar expressões **lógicas e relacionais**.

#### **Exemplo 1**
- Usar `{}` para delimitar o bloco `switch`.
- Cada `case` usa `:` e finaliza com `break`.

---

## **Estruturas de Repetição**

- Utilizadas quando precisamos executar o mesmo procedimento diversas vezes.
- Em C#, temos três estruturas principais:
  - `for`
  - `while`
  - `do...while`

---

## **Estrutura `for`**

- Permite repetir trechos de código.
- Usa uma **variável contadora**.
- Inclui:
  - Valor inicial
  - Condição de parada
  - Incremento/decremento

#### **Sintaxe**
```csharp
for (valor_inicial; condição; incremento) {
    <bloco de instruções>;
}
```

#### **Exemplo:**
Executar um laço de repetição 4 vezes:
```csharp
for (int i = 0; i < 4; i++) {
    Console.WriteLine("i vale " + i);
}
```
- `i = 0`: valor inicial
- `i < 4`: condição de parada
- `i++`: incremento

---

## **Entendendo o Exemplo 1**
Fluxo da execução do `for`:
```
i = 0 → condição i < 4? → Sim → executa → incrementa
i = 1 → condição i < 4? → Sim → executa → incrementa
i = 2 → ...
i = 3 → ...
i = 4 → condição i < 4? → Não → encerra
```

---

## **Controle do laço `for`**

### **Comando `break`**
- Encerra o laço **imediatamente**, mesmo que a condição ainda seja verdadeira.

### **Comando `continue`**
- Pula o restante do bloco **e segue para a próxima iteração**.

---

## **Exemplo 1 com `break`**
- Ler continuamente o valor de uma variável `op`.
- Finalizar quando `op == 0`.

```csharp
while (true) {
    int op = int.Parse(Console.ReadLine());
    if (op == 0) break;
}
```

---

## **Exemplo 2 com `continue`**
- Ler a variável `opcao`.
- Só prosseguir se o valor estiver entre 1 e 4.
- Caso contrário, voltar para o início do laço.

```csharp
int opcao;
do {
    opcao = int.Parse(Console.ReadLine());
    if (opcao < 1 || opcao > 4) continue;
    // prossegue com a lógica
} while (opcao != 0);
```

---

## **Exemplo 3: `for` dentro de `for`**
- Estrutura de laços aninhados (um `for` dentro de outro).

---

## **Exemplo 4: `for` dentro de `for` dentro de `for`**
- Três laços aninhados, usados em casos mais complexos como matrizes 3D ou geração de combinações.

**Fonte do conteúdo:** Arquivo enviado por você: **"Aula 03 - Programação .NET - Laço repetição.pdf"**  


---

### **Programação .NET**  
**Professor Ricardo Frohlich da Silva**

---

## **Estruturas Condicionais**

### **Estrutura condicional**
- Permite testar uma condição.
- O resultado pode ser:
  - Verdadeiro
  - Falso
- Dependendo do resultado, um conjunto de instruções é executado.

---

### **Comando `if-else` - Sintaxe**
- **Sem `else`**:
  ```csharp
  if (condição) {
      <conjunto de instruções>
  }
  ```

- **Com `else`**:
  ```csharp
  if (condição) {
      <conjunto de instruções 1>
  } else {
      <conjunto de instruções 2>
  }
  ```

---

### **Exemplos práticos**
1. **Informar se número é negativo**
   - Questão levantada: e se o número for positivo?

2. **Informar se número é positivo ou negativo**
   - Questão: e se o número for **zero**?

3. **Versão completa**: identificar se o número é positivo, negativo ou zero.

---

### **Exemplo: verificar divisibilidade**
- Informar se número é divisível por 2, 4 ou 8.

#### **Como testar divisibilidade por 2**
```csharp
if (num % 2 == 0) {
    Console.WriteLine("É divisível!");
} else {
    Console.WriteLine("Não é divisível!");
}
```

#### **Questões abordadas**
- E se o número for divisível por 4?
- E por 8?
- Pode ser divisível por mais de um ao mesmo tempo?
- Como implementar isso no código?

---

### **Opções de solução apresentadas para o exemplo 4**
- Foram mostradas três opções (OPÇÃO 1, 2, 3) de estrutura de código.
- Conclusão: **OPÇÃO 3** foi a escolhida como mais adequada.

---

### **Operadores relacionais**

| Operador | Ação               |
|----------|--------------------|
| `>`      | Maior que          |
| `<`      | Menor que          |
| `>=`     | Maior ou igual a   |
| `<=`     | Menor ou igual a   |
| `==`     | Igual a            |
| `!=`     | Diferente de       |

---

### **Exemplos com operadores**

- Exemplo 5: verificar se número é divisível por 2, 3 e 4 ao mesmo tempo.
- Exemplo 6: uso de `>=`
- Exemplo 7: uso de `<`
- Exemplo 8: uso de `<=`
- Exemplo 9: uso de `==`
- Exemplo 10: uso de `!=`
- Exemplo 11: `==` com `else`
- Exemplo 12: escolher operação com base no valor

---

### **Exercício prático**
- Utilizando a calculadora desenvolvida, leia a operação e realize o cálculo:
  1. Soma  
  2. Subtração  
  3. Divisão  
  4. Multiplicação  

---

## **Estruturas Seletivas**

### **Comando `switch-case`**
- É uma estrutura de seleção múltipla.
- Testa uma expressão contra **constantes inteiras ou caracteres**.
- **Importante:** só funciona para valores inteiros ou caracteres.
- Diferente do `if`, que aceita expressões mais complexas.

#### **Sintaxe `switch-case`**
```csharp
switch (variável) {
    case valor1:
        // instruções
        break;
    case valor2:
        // instruções
        break;
    default:
        // instruções padrão
        break;
}
```

- Observações:
  - Sempre utilizar `{}` ao iniciar `switch`.
  - Cada `case` usa `:` e termina com `break`.

---
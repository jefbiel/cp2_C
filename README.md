# 📝 Checkpoint 2 - Programação Orientada a Objetos em C#

## 📌 Descrição

Este repositório contém a resolução do **Checkpoint 2**, uma avaliação individual focada nos conceitos fundamentais de **Programação Orientada a Objetos (POO)** utilizando a linguagem C#.

A proposta da atividade é avaliar a compreensão teórica e prática dos principais pilares da orientação a objetos, bem como a capacidade de aplicá-los por meio de exemplos e implementações em código.

---

## 🎯 Objetivos

- Compreender e explicar os quatro princípios da POO:
  - Encapsulamento
  - Herança
  - Polimorfismo
  - Abstração
- Diferenciar conceitos essenciais como **classe** e **objeto**
- Aplicar corretamente **modificadores de acesso**
- Entender e implementar:
  - Sobrecarga de métodos (*overloading*)
  - Sobrescrita de métodos (*overriding*)
- Desenvolver classes completas em C#
- Criar hierarquias de classes com uso de polimorfismo

---

## 📚 Conteúdos Abordados

### 1. Conceitos Fundamentais da POO
Explicação dos quatro pilares da orientação a objetos com exemplos práticos em C#.

### 2. Classe vs Objeto
Definição e exemplificação da criação de classes e instâncias.

### 3. Modificadores de Acesso
Uso de:
- `public`
- `private`
- `protected`

E suas aplicações no design de classes.

### 4. Sobrecarga e Sobrescrita
Implementação e comparação entre:
- Overloading (sobrecarga)
- Overriding (sobrescrita)

---

## 💻 Exercícios Práticos

### 📖 Classe `Livro`
Implementação de uma classe com:
- Propriedades: `Titulo`, `Autor`, `AnoPublicacao`
- Construtor para inicialização
- Método para exibir informações formatadas

---

### 🚗 Hierarquia de Veículos

Criação de um sistema utilizando herança e polimorfismo:

- Classe base: `Veiculo`
- Classes derivadas:
  - `Carro`
  - `Caminhao`
  - `Moto`

Cada classe sobrescreve o método `Acelerar()`, demonstrando comportamento polimórfico.

---

## ⚙️ Estrutura do Projeto

```bash
Program.cs        # Execução principal e testes
Livro.cs          # Implementação da classe Livro
Veiculo.cs        # Classe base
Carro.cs          # Classe derivada
Caminhao.cs       # Classe derivada
Moto.cs           # Classe derivada

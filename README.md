# 🚕 Serviço de Taxi Online (.NET) - Em Construção

## 📋 Sobre o Projeto

Implementação em C#/.NET do projeto de Serviço de Taxi Online do curso [Clean Code & Clean Architecture](https://www.branas.io/) do Rodrigo Branas, adaptando conceitos de design e arquitetura originalmente demonstrados em Node.js/TypeScript

### 🎯 Funcionalidades Principais

**Gestão de Contas:**
- Criação de contas para passageiros e motoristas
- Validação de CPF, email único e dados obrigatórios
- Autenticação e autorização por perfil

**Fluxo de Corridas:**
- **Solicitação**: Passageiro informa origem/destino (coordenadas)
- **Aceitação**: Motorista disponível aceita a corrida
- **Execução**: Tracking em tempo real com atualizações de posição
- **Finalização**: Cálculo automático de tarifa e processamento de pagamento

**Cálculo de Tarifa Dinâmica:**
- Dia normal (8h-22h): R$ 2,10/km
- Dia normal (22h-8h): R$ 3,90/km  
- Domingo (8h-22h): R$ 2,90/km
- Domingo (22h-8h): R$ 5,00/km

**Status da Corrida:** SOLICITADA → ACEITA → EM_ANDAMENTO → CONCLUÍDA

### 🏗️ Arquitetura

Inicialmente seguindo **Clean Architecture** e os padrões de design do **Domain-Driven Design (DDD)**:

```
src/
├── Domain/          # Regras de negócio
├── Application/     # Casos de uso e interfaces
├── Infrastructure/  # Implementações e Persistência (Banco de Dados, APIs externas)
├── WebAPI/          # Controllers
└── Web/            # Frontend em Vue.js
```

## 🚀 Tecnologias Utilizadas

### Backend
- **.NET 9** - Framework principal
- **Entity Framework Core** - ORM
- **PostgreSQL** - Banco de dados
- **xUnit** - Testes unitários
- **Coverlet** - Cobertura de testes
- Em Construção

### Frontend
- **Vue.js 3** - Framework SPA
- **Composition API**
- **TypeScript**
- Em Construção

### DevOps
- Em Construção
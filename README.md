# Exchange Rate API

## Visão Geral
Este projeto consiste em uma WebAPI desenvolvida em .NET que realiza a conversão da moeda Dólar Americano (USD) para Reais (BRL) utilizando o serviço da ExchangeRate-API. A API faz uma chamada ao endpoint do serviço de câmbio e retorna o valor do USD em BRL.

## Funcionalidades Principais
- **Implementação da Interface IConversionRate**: Lida com a lógica de conversão de moeda, armazenando a taxa de câmbio do BRL.
- **Implementação da Interface IExchangeController**: Expondo o endpoint de conversão de moeda, permitindo que clientes solicitem a taxa de conversão de USD para BRL.
- **Chamada ao Endpoint Exchangerate-API**: Realiza a chamada ao endpoint `https://v6.exchangerate-api.com` e valida a resposta para garantir que a solicitação foi bem-sucedida.
- **Swagger**: A WebAPI inclui uma interface Swagger bem formatada, permitindo explorar e testar a API diretamente do navegador.

## Estrutura do Projeto
- **Controllers/ExchangeController.cs**: Controlador responsável pelo endpoint `/api/exchange`, que faz a chamada ao serviço de câmbio e retorna a conversão de USD para BRL.
- **Interfaces/IConversionRate.cs**: Interface que define o contrato para o serviço de conversão de moeda.
- **Interfaces/IExchangeController.cs**: Interface que define o contrato para o controlador responsável pela conversão.
- **Program.cs**: Configuração da WebAPI, incluindo injeção de dependências e configuração do Swagger.

## Endpoints Disponíveis
### 1. GET `/api/exchange`
Retorna o valor da taxa de câmbio de USD para BRL.

### 2. GET `GET /swagger`
Mostra a documentação do Swagger

### Equipe
Matheus Colossal (Desenvolvedor FullStack | Java) - RM 99572

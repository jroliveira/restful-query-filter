# RESTful Query Filter

[![Build status](https://ci.appveyor.com/api/projects/status/ya2m0rky5km1p44q?svg=true)](https://ci.appveyor.com/project/junioro/restful-query-filter)
[![Build Status](https://travis-ci.org/jroliveira/restful-query-filter.svg?branch=master)](https://travis-ci.org/jroliveira/restful-query-filter)
[![Coverage Status](https://coveralls.io/repos/jroliveira/restful-query-filter/badge.svg?branch=master&service=github)](https://coveralls.io/github/jroliveira/restful-query-filter?branch=master)
[![NuGet](https://img.shields.io/nuget/dt/Restful.Query.Filter.svg)](https://www.nuget.org/packages/Restful.Query.Filter/)
[![NuGet](https://img.shields.io/nuget/v/Restful.Query.Filter.svg)](https://www.nuget.org/packages/Restful.Query.Filter/)

Sistema de filtro baseado no projeto [StrongLoop Node.js API Platform][strongloop] desenvolvido pela [Atlassian Confluence][atlassian].

## Features

### Limit

Retorna apenas a quantidade de dados passada no filtro ou menos dados.

Exemplo:

``` js
/accounts?filter[limit]=5
```

### Skip

Retorna apenas os dados ignorando os primeiros registros retornados na consulta. Geralmente � utilizado para pagina��o.

Exemplo:

``` js
/accounts?filter[skip]=1
```

### Order

Retorna os dados ordenados de forma crescente (asc) ou decrescente(desc) com base em um propriedade especifica.

Exemplos:

De forma CRESCENTE:

``` js
/accounts?filter[order]=name%20asc
```

De forma DECRESCENTE:

``` js
/accounts?filter[order]=name%20desc
```

De forma crescente E decrescente:

``` js
/accounts?filter[order][0]=id%20asc&filter[order][1]=name%20desc
```

### Where

Retorna os dados respeitando as condi��es solicitadas.

Exemplos:

Onde for IGUAL:

``` js
/accounts?filter[where][id]=100
```

Onde for MAIOR QUE:

``` js
/accounts?filter[where][id][gt]=100
```

Onde for MENOR QUE:

``` js
/accounts?filter[where][id][lt]=100
```

Onde for maior que E igual:

``` js
/accounts?filter[where][and][0][id][gt]=100&filter[where][and][1][name]=junior
```

Onde for menor que OU igual:

``` js
/accounts?filter[where][or][0][id][lt]=100&filter[where][or][1][name]=junior
```

### Fields

Retorna os dados respeitando a configura��o de visualiza��o de cada campo.

obs.: A coluna por padr�o ser� retornada na consulta.

Exemplos:

Onde for VERDADEIRO:

``` js
/accounts?filter[fields][id]=true
```

Onde for FALSO:

``` js
/accounts?filter[fields][id]=false
```

## Instala��o

* `Install-Package Restful.Query.Filter`

## Rodar os testes

* `git clone https://github.com/jroliveira/restful-query-filter.git`
* `bundler`
* `rake test`

## Contribui��es

1. Fork it
2. git checkout -b <branch-name>
3. git add --all && git commit -m "feature description"
4. git push origin <branch-name>
5. Create a pull request

[strongloop]: https://docs.strongloop.com/display/SL/Installing+StrongLoop
[atlassian]: https://www.atlassian.com/software/confluence
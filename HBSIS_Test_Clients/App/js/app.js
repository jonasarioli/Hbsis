(function () {
    'use strict';

    angular.module('app', [
        // Angular modules 
        'ngRoute'

        // Custom modules 

        // 3rd Party Modules
        
    ]);
    var config = function ($routeProvider) {
        $routeProvider
        .when("/",
               { templateUrl: "/cliente/html/lista.html", controller: "listaController" })
        .when("/detalhes/:id",
               { templateUrl: "/cliente/html/detalhes.html", controller: "detalhesController" })
        .otherwise(
               { redirecTo: "/" });
    };
    app.config(config);
    app.constant("clienteApiUrl", "/api/cliente/");
})();
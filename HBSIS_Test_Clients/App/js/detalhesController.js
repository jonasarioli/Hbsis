(function (app) {
    var detalhesController = function ($scope, $routeParams, clienteService) {
        var id = $routeParams.id;
        clienteService
            .getClientePorId(id)
            .success(function (data) {
                $scope.cliente = data;
        });
    };
    app.controller("detalhesController", detalhesController)
}(angular.module("app")));
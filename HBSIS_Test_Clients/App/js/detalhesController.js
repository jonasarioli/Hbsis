(function (app) {
    var detalhesController = function ($scope, $routeParams, clientService) {
        var id = $routeParams.id;
        clientService
            .getClientePorId(id)
            .then(function (data) {
                $scope.cliente = data.data;
            });

        $scope.editar = function () {
            $scope.editar.cliente = angular.copy($scope.cliente);
        };
    };
    app.controller("detalhesController", detalhesController)
}(angular.module("app")));
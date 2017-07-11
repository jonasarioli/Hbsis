(function (app) {
    var detalhesController = function ($scope, $routeParams, clientService) {
        var id = $routeParams.id;
        clientService
            .getClientePorId(id)
            .success(function (data) {
                $scope.cliente = data;
            });

        $scope.editar = function () {
            $scope.editar.filme = angular.copy($scope.filme);
        };
    };
    app.controller("detalhesController", detalhesController)
}(angular.module("app")));
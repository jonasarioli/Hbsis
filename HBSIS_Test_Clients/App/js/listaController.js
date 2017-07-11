(function (app) {
    var listaController = function ($scope, clientService) {
        clientService
            .getClientes()
            .success(function (data) {
                $scope.clientes = data;
            });

        $scope.criar = function () {
            $scope.editar = {
                cliente: {
                    Nome: "",
                    Codigo: "",
                    Documento: "",
                    Telefone: ""
                }
            };
        };

        $scope.deleta = function (cliente) {
            clientService.deletar(cliente)
            .success(function () {
                removerClientePorId(cliente.Id);
            });
        };

        var removerClientePorId = function (id) {
            for (var i = 0; i < $scope.clients.length; i++) {
                if ($scope.clientes[i].Id == id) {
                    $scope.clientes.splice(i, 1);
                    break;
                }
            }
        };
    };

    app.controller('listaController', listaController);
}(angular.module("app")))
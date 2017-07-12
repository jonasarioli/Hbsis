(function (app) {
    var listaController = function ($scope, clientService) {
        clientService
            .getClientes()
            .then(function (data) {
                var clientesData = data;
                $scope.clientes = clientesData.data;
            });

        $scope.criar = function () {
            $scope.editar = {
                cliente: {
                    Id: 0,
                    Nome: "",
                    Codigo: "",
                    Documento: "",
                    Telefone: ""
                }
            };
        };

        $scope.deleta = function (cliente) {
            clientService.deletar(cliente)
            .then(function () {
                removerClientePorId(cliente.Id);
            });
        };

        var removerClientePorId = function (id) {
            for (var i = 0; i < $scope.clientes.length; i++) {
                if ($scope.clientes[i].Id == id) {
                    $scope.clientes.splice(i, 1);
                    break;
                }
            }
        };
    };

    app.controller('listaController', listaController);
}(angular.module("app")))
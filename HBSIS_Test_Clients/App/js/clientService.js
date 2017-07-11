(function (app) {
    var clientService = function ($http, clienteApiUrl) {

        var getclientes = function () {
            return $http.get(clienteApiUrl);
        };
        var getclientePorId = function (id) {
            return $http.get(clienteApiUrl + id);
        };
        var atualizar = function (cliente) {
            return $http.put(clienteApiUrl + cliente.Id, cliente);
        };
        var criar = function (cliente) {
            return $http.post(clienteApiUrl, cliente);
        };
        var deletar = function (cliente) {
            return $http.delete(clienteApiUrl + cliente.Id);
        };
        return {
            getClientes: getclientes,
            getClientePorId: getclientePorId,
            atualizar: atualizar,
            criar: criar,
            deletar: deletar
        };
    };
    app.factory("clientService", clientService);
}(angular.module("app")))
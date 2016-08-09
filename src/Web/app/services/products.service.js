(function () {
    'use strict';

    angular
        .module('tutorialMaterialDesign')
        .service('productsService', productsService);

    productsService.$inject = ['$http', '$q'];

    function productsService($http, $q) {
        this.getProducts = getProducts;

        function getProducts() {
            var deferred = $q.defer();

            $http({ method: "GET", url: "/api/products" })
                .success(function (data, status, headers, config) {
                    deferred.resolve(data);
                })
                .error(function (data, status, headers, config) {
                    deferred.reject(status);
                });

            return deferred.promise;
        };
    }
})();
(function () {
    'use strict';

    angular
        .module('tutorialMaterialDesign')
        .controller('productsController', productsController);

    productsController.$inject = ['productsService'];

    function productsController(productsService) {

        var vm = this;
        vm.title = 'products';
        vm.loadProducts = loadProducts;
        vm.changeProduct = changeProduct;
        vm.removeProduct = removeProduct;
        vm.products = undefined;

        activate();

        function removeProduct(product) {
            vm.products.splice(vm.products.indexOf(product), 1)
        }

        function changeProduct() {
            vm.products[3].Name = "teetetetetetetet";
        }

        function loadProducts() {
            productsService.getProducts().then(function (products) {
                vm.products = products;
            });
        }

        function activate() {
            productsService.getProducts().then(function (products) {
                vm.products = products;
            });
        }
    }
})();
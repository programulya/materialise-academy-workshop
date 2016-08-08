﻿(function() {
    'use strict';

    angular
        .module('angularDemoApp')
        .controller('homeController', homeController);

    homeController.$inject = ['criminalFactory', '$scope', '$templateCache'];

    function homeController(criminalFactory, $scope, $templateCache) {
        var vm = this;
        vm.title = 'homeController';
        vm.deleteCriminal = deleteCriminal;

        activate();

        function activate() {
            getAllCriminal();
        }

        function deleteCriminal(id) {
            criminalFactory.deleteByID(id)
                .success(function() {
                });
        }

        function getAllCriminal() {
            criminalFactory.getAll()
                .success(function(result) {
                    vm.criminals = result;
                });
        };
    }
})();
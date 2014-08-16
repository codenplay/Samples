"use strict";

app.controller('studentListController', ['$scope', 'studentService', function ($scope, studentService) {
    $scope.students = [];

    function initialize() {
        studentService.search().$promise.then(function (response) {
            console.log(response);
            if (response.IsSuccess) {
                $scope.students = studentService.processData(response.Data);
            }
        });
    };


    initialize();
    }
]);
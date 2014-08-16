'use strict';


// Declare app level module which depends on filters, and services
var app = angular.module('app', ['ngRoute','ngResource']);

app.config(['$routeProvider', function ($routeProvider) {
  $routeProvider.when('/', { templateUrl: 'partials/studentList.html', controller: 'studentListController' });
  $routeProvider.when('/student', { templateUrl: 'partials/student.html', controller: 'studentController' });
  $routeProvider.otherwise({redirectTo: '/'});
}]);

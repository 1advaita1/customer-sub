    var app = angular.module('NgCS', []);
    app.controller('NgCtrl', function ($scope, $http) {
        $http.get("http://localhost:55086/api/CustomerSubscription/detail/get").then(function (response) {
            console.log(response);
            $scope.name = response.data.CustomerName;
            $scope.type = response.data.CustomerType;
            $scope.subFrom = response.data.SubFrom;
            $scope.subTo = response.data.SubTo;
        });
    });
    
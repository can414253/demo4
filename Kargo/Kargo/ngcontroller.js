var app = angular.module('Kargo', []);
app.controller('urunislemleri', function ($scope, $http) {
    
    $http.get("http://localhost:44389/api/Urun/TumUrunleriGetir") .then(function (response) {
            $scope.urunler = response.data;
        });
    $scope.urunsil = function (silinecekID)
    {
        $http.get("http://localhost:44389/api/Urun/UrunSilId", { params: { id: silinecekID } }).then(function (response) {
            $scope.urunler = response.data;
        });
    }
});
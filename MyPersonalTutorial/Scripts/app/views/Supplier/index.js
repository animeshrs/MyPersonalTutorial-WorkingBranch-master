var id = -1;

$(document).on("click", "#tblSupplier tbody tr", function () {
    $("#supplierModal").modal("show");

    id = $(this).attr('supplierid');
    console.log(id);
});

var myApp = angular.module("myApp", [])
            .controller("myController", function ($scope, $http) {
                console.log("start");
                $http.get("/api/Supplier/GetAllSupplierList")
                .then(function (response) {
                    console.log("finished");
                    $scope.suppliers = response.data;

                    $scope.headers = [
                        { name: 'CompanyName', val: 'Company Name' },
                        { name: 'ContactName', val: 'Contact Name' },
                        { name: 'ContactTitle', val: 'Contact Title' }
                    ];

                    $scope.sortColumn = "CompanyName";
                    $scope.reverse = false;
                    $scope.orderByColumn = function (column) {
                        var currentColumn = $scope.sortColumn;
                        $scope.sortColumn = column;

                        if (column === currentColumn)
                            $scope.reverse = !$scope.reverse;
                    };


                    $scope.test = function (data) {
                        console.log(data);
                    };

                    $scope.companyName = id;
                });
            });

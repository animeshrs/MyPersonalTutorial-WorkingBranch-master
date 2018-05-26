define(function (require) {
    require('jquery');
    var mediator = require('mediator');
    require('amplify');

    var get = function () {
        $.ajax({
            url: '/api/Employees/GetEmployees',
            success: function (response) {
                mediator.publish(mediator.channels.data.employees.employeeListRetrieved, response);
            }
        });
    };

    //var get = function (employeeId) {
    //    amplify.request({
    //        resourceId: "employees",
    //        data: employeeId,
    //        success: function (data) {
    //            console.log("data", data);  
    //            mediator.publish(mediator.channels.data.employees.employeeListRetrieved, data);
    //        },
    //        error: function (response) {
    //            console.log(response);
    //        }
    //    });
    //};

    var create = function (data) {
        amplify.subscribe("storedData", function (data) {
            console.log(data);
        });
        $.ajax({
            url: '/api/Employees/AddEmployee',
            data: data,
            type: 'POST',
            success: function (response) {
                mediator.publish(mediator.channels.data.employees.createEmployeeListRetrieved, response);
            }
        });
    };

    var initialize = function () {
        //amplify.request.define("employees", "ajax", {
        //    url: '/api/Employees/GetEmployeeById',
        //    dataType: "json",
        //    type: "GET"
        //});

        mediator.subscribe(mediator.channels.data.employees.employeeListRequested, get);
        mediator.subscribe(mediator.channels.data.employees.createEmployeeListRequested, create);
    };

    return {
        initialize: initialize
    };
});
define(function (require) {
    require('jquery');
    var mediator = require('mediator');
    var service = require('app/services/Employee/employeeService');
    require('amplify');

    var uiEmployeeTable = $("#tblEmployees");
    var uiBtnCreate = $("#btn-create");
    var uiCreateModal = $("#createEmployeeModal");
    var uiCreateForm = $("#createEmployeeForm");
    var uiBtnCreateSave = $("#btn-create-save");

    var updateView = function (data) {
        var uiTableBody = uiEmployeeTable.find('tbody');
        data.forEach(function (element) {
            var newTr =
                "<tr>\
                    <td>" + element.TitleOfCourtesy + "</td>\
                    <td>" + element.Name + "</td>\
                    <td>" + element.Title + "</td>\
                    <td>" + element.BirthDate + "</td>\
                 </tr>";
            uiTableBody.append(newTr);
        });
    };

    var getEmployeeList = function (data) {
        console.log(data);
        updateView(data);
        amplify.store("data", data);
    };

    uiBtnCreate.on("click", function () {
        uiCreateModal.modal("show");
    });

    uiBtnCreateSave.on("click", function () {
        var data = uiCreateForm.serialize();
        mediator.publish(mediator.channels.data.employees.createEmployeeListRequested, data);
        var data = amplify.store("data") || ["NA"];
        amplify.publish("storedData", data);
    });

    var appendData = function (data) {
        var newTr = "<tr>\
                        <td>" + data.Title + " </td>\
                        <td>" + data.Name + " </td>\
                        <td>" + data.TitleOfCourtesy + " </td>\
                        <td>" + data.BirthDate + " </td>\
                    </tr>";
        uiEmployeeTable.find("tbody").append(newTr);
    };

    var getCreateResponse = function (data) {
        appendData(data);
        uiCreateModal.modal("hide");
    };

    var initialize = function () {
        service.initialize();
        var employeeId = 1;
        mediator.publish(mediator.channels.data.employees.employeeListRequested, employeeId);
        mediator.subscribe(mediator.channels.data.employees.employeeListRetrieved, getEmployeeList);
        mediator.subscribe(mediator.channels.data.employees.createEmployeeListRetrieved, getCreateResponse);
    };

    return {
        initialize: initialize
    };
});
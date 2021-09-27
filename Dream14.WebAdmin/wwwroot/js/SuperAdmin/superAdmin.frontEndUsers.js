$(document).ready(function () {
    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // DataTable for Admin users
    var userListTable = $('#tblFrontEnds').DataTable({

        "pageLength": 10
    });

    $(".dataTables_empty").text("There are no frontEnds yet.");

    // Search on Admin user Grid using Search Text box
    $('#txtSearchFrontEndList').keyup(function () {
        userListTable.search($(this).val()).draw();
    });

    var rowsCount = $('#tblFrontEnds tbody tr').length;
    //alert(rowsCount);
    if (rowsCount < 10) {
        $("#tblFrontEnds_paginate").hide();
    }
    else {
        $("#tblFrontEnds_paginate").show();
    }

    if (rowsCount <= 1) {
        $("#btnDeleteAllCheckedFrontEnd").hide();
        //$(".table_checkbox").hide();
    }
    else {
        $("#btnDeleteAllCheckedFrontEnd").show();
        // $(".table_checkbox").show();
    }

    // Hide un-neccessary controls of datatable plugin for Admin User tables
    $('.dataTables_length').hide();
    $('.dataTables_filter').hide();
    $('.dataTables_info').hide();

    // Delete all checked user on top delete button click
    $("#btnDeleteAllCheckedFrontEnd").on("click", function () {

        var targetIds = {};
        targetIds.ItemIds = [];

        $('#tblAgents').find('input[type="checkbox"]:checked').each(function () {

            var row = $(this).parents('tr')[0];;
            var userId = parseInt($(row).find('span').text());
            targetIds.ItemIds.push(userId);
        });

        if (targetIds.ItemIds.length > 0) {
            swal({
                title: 'Are you sure you want to delete these frontEnds?',
                text: "",
                type: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes',
                cancelButtonText: 'No',
                width: '500px'
            }).then(function (result) {
                if (result.value) {
                    //  deleteUsers method to delete admin users
                    frontEndDataService.deleteFrontEnds("/SuperAdmin/DeleteFrontEndUsers", targetIds, deletedCheckedFrontEndCallback);
                }
            });
        }

        else {
            swal('Please check at least one frontEnd to delete using the checkboxes.');
        }

    });

    // Delete User Confirnation Modal Popup

    $('#tblFrontEnds').on('click', '.frontEndItem', function () {
        // Find the targeted User Id that will be deleted
        var row = $(this).parents('tr')[0];;
        var userId = parseInt($(row).find('span').text());
        var targetIds = {};
        targetIds.ItemIds = [];
        targetIds.ItemIds.push(userId);

        swal({
            title: 'Are you sure you want to delete this frontEnd?',
            text: "",
            type: 'warning',
            showCancelButton: true,
            confirmButtonColor: '#3085d6',
            cancelButtonColor: '#d33',
            confirmButtonText: 'Yes',
            cancelButtonText: 'No'
        }).then(function (result) {

            if (result.value) {
                //  deleteUsers method to delete admin users
                frontEndDataService.deleteFrontEnds("/SuperAdmin/DeleteFrontEndUsers", targetIds, deletedFrontEndCallback);
            }
        });
    });

    // All data communication will be happened using this agentDataService object from server
    var frontEndDataService = new function () {
        deleteFrontEnds = function (url, users, callback) {
            $.post(url, { targetIds: users }, function (data) { callback(data) });
        }

        return {
            deleteFrontEnds: deleteFrontEnds
        };
    }();

    // Callback function of Checked Deleted Users
    var deletedCheckedFrontEndCallback = function (data) {
        console.table(data);
        if (data.isSuccess == false) {

            if (data.message == "1") {
                swal(
                    'You cannot delete these frontEnd(s), it is associated with other frontend users.',
                    '',
                    'error'
                ).then(function () {

                    var rowsCount = $('#tblFrontEnds tbody tr').length;

                    if (rowsCount <= 1) {
                        $("#btnDeleteAllCheckedFrontEnd").hide();
                        //$(".table_checkbox").hide();
                    }
                    else {
                        $("#btnDeleteAllCheckedFrontEnd").show();
                        // $(".table_checkbox").show();
                    }

                    window.location.href = "/SuperAdmin/FrontEndUsers";
                });
            }
        }
        else {
            swal(
                'The frontEnd(s) have been successfully deleted.',
                '',
                'success'
            ).then(function () {

                var rowsCount = $('#tblFrontEnds tbody tr').length;

                if (rowsCount <= 1) {
                    $("#btnDeleteAllCheckedAgent").hide();
                    //$(".table_checkbox").hide();
                }
                else {
                    $("#btnDeleteAllCheckedAgent").show();
                    // $(".table_checkbox").show();
                }

                window.location.href = "/SuperAdmin/FrontEndUsers";
            });
        }
    }



    // Callback function of Deleted Users
    var deletedFrontEndCallback = function (data) {
        if (data.isSuccess == false) {

            if (data.message == "1") {
                swal(
                    'You cannot delete these frontEnd(s), it is associated with other frontend users.',
                    '',
                    'error'
                ).then(function () {

                    var rowsCount = $('#tblFrontEnds tbody tr').length;

                    if (rowsCount <= 1) {
                        $("#btnDeleteAllCheckedFrontEnd").hide();
                        //$(".table_checkbox").hide();
                    }
                    else {
                        $("#btnDeleteAllCheckedFrontEnd").show();
                        // $(".table_checkbox").show();
                    }

                    window.location.href = "/SuperAdmin/FrontEndUsers";
                });
            }
        }
        else {
            swal(
                'The frontEnd(s) have been successfully deleted.',
                '',
                'success'
            ).then(function () {

                var rowsCount = $('#tblFrontEnds tbody tr').length;

                if (rowsCount <= 1) {
                    $("#btnDeleteAllCheckedFrontEnd").hide();
                    //$(".table_checkbox").hide();
                }
                else {
                    $("#btnDeleteAllCheckedFrontEnd").show();
                    // $(".table_checkbox").show();
                }

                window.location.href = "/SuperAdmin/FrontEndUsers";
            });
        }
    }

});





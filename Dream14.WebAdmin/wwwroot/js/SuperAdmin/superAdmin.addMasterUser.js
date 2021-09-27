$(document).ready(function () {

    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // Select creation date as today
    $('#CreationDate').val(getFormattedDate());

    $("#Save_Master_Btn").click(function () {
        debugger;
        if (validateAddMasterMessage() == false) {
            return false;
        }
        else if (ValidateEmailAddress() == false) {
            return false;
        }
        else {

        }
    });

});


function ValidateEmailAddress() {
    debugger;
    if ($('#UserName').val().trim() != "") {
        var testEmail = /^[A-Z0-9._%+-]+@([A-Z0-9-]+\.)+[A-Z]{2,4}$/i;
        var userName = $('#UserName').val().trim();
        $.ajax({
            type: "POST",
            url: "/SuperAdmin/CheckUserNameExists",
            data: { userName: userName },
            async: false,
            success: function (data) {
                debugger;
                if (data.message == "UserName Not Exists") {
                    //return true;
                    $.ajax({
                        type: "POST",
                        url: "/SuperAdmin/AddMasterUser",
                        async: false,
                        beforeSend: function (xhr) {
                            onBegin(xhr);
                        },
                        data: { Name: $('#Name').val(), UserName: $('#UserName').val(), Password: $('#Password').val(), MobileNumber: $('#MobileNumber').val() },
                        success: function (data) {
                            onSuccess(data);
                        },
                        error: function (e) {
                            onFailed(e);
                        }
                    });
                }
                else {
                    $("span[id='UserName_Error']").text("UserName already exists. Please try with different one");
                    return false;
                }
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });

    }
}

var onBegin = function () {
    $(".loaderModal").show();
};


var onComplete = function () {
    //alert("onComplete");
};

var onSuccess = function (context) {
    $(".loaderModal").hide();
    swal(
        'The master user was successfully created.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/MasterUsers";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};



// Validate Featured Message form
var validateAddMasterMessage = function () {
    var isValid = true;

    if ($("#Name").val().trim().length == 0) {
        $("span[id='Name_Error']").text("Please enter the name.");
        isValid = false;

    }
    else {
        $("span[id='Name_Error']").text("");
    }


    if ($("#UserName").val().trim().length == 0) {
        $("span[id='UserName_Error']").text("Please enter the username.");
        isValid = false;
    }
    else {
        $("span[id='UserName_Error']").text("");
    }


    if ($("#Password").val().trim().length == 0) {
        $("span[id='Password_Error']").text("Please enter the password.");
        isValid = false;

    }
    else {
        $("span[id='Password_Error']").text("");
    }


    if ($("#MobileNumber").val().trim().length == 0) {
        $("span[id='MobileNumber_Error']").text("Please enter the mobile number.");
        isValid = false;

    }
    else {
        $("span[id='MobileNumber_Error']").text("");
    }



    return isValid;


}


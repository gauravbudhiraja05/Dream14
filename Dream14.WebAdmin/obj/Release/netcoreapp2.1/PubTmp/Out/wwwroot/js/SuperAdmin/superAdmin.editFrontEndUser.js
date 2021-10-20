$(document).ready(function () {

    //Select Current Menu
    $('.nav-li').removeClass('current');
    $('#menuItemSuperAdmin').addClass('current');

    // Select creation date as today
    //$('#CreationDate').val(getFormattedDate());

    $("#Update_FrontEnd_Btn").click(function () {
        debugger;
        if (validateUpdateFrontEndMessage() == false) {
            return false;
        }
        else if (ValidateUserName() == false) {
            return false;
        }
        else {

        }
    });

});


function ValidateUserName() {
    debugger;
    if ($('#UserName').val().trim() != "") {
        var emailAddress = $('#UserName').val().trim();
        if ($('#hdnUserName ').val() != emailAddress) {
            $.ajax({
                type: "POST",
                url: "/SuperAdmin/CheckUserNameExists",
                data: { emailAddress: emailAddress },
                async: false,
                success: function (data) {
                    debugger;
                    if (data.message == "UserName Not Exists") {
                        //return true;
                        $.ajax({
                            type: "POST",
                            url: "/SuperAdmin/EditFrontEndUser",
                            async: false,
                            beforeSend: function (xhr) {
                                onBegin(xhr);
                            },
                            data: { Name: $('#Name').val(), UserName: $('#UserName').val(), Password: $('#Password').val(), UserId: $('#UserId').val(), MobileNumber: $('#MobileNumber').val(), UserType: $('#UserType').val() },
                            success: function (data) {
                                onSuccess(data);
                            },
                            error: function (e) {
                                onFailed(e);
                            }
                        });

                    }
                    else {
                        $("span[id='UserName_Error']").text("UserName address already exists. Please try with different one");
                        return false;
                    }
                },
                error: function (e) {
                    onFailed(e);
                    return false;
                }
            });
        }
        else {
            $.ajax({
                type: "POST",
                url: "/SuperAdmin/EditFrontEndUser",
                async: false,
                beforeSend: function (xhr) {
                    onBegin(xhr);
                },
                data: { Name: $('#Name').val(), UserName: $('#UserName').val(), Password: $('#Password').val(), UserId: $('#UserId').val(), MobileNumber: $('#MobileNumber').val(), UserType: $('#UserType').val() },
                success: function (data) {
                    onSuccess(data);
                },
                error: function (e) {
                    onFailed(e);
                }
            });
        }

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
        'The frontEnd user was successfully updated.',
        '',
        'success'
    ).then(function () {
        window.location.href = "/SuperAdmin/FrontEndUsers";
    });
};

var onFailed = function (context) {
    //alert("Failed");
};

// Validate Featured Message form
var validateUpdateFrontEndMessage = function () {
    var isValid = true;

    // check if the form input is valid
    if (!$("#formFrontEnd").valid()) {
        $("#formFrontEnd").submit();
        isValid = false;
    }


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


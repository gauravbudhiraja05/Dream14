$(document).ready(function () {

    $("#btnPassword").click(function () {

        if (ValidateForm() == false) {
            return false
        }
        else {
            if ($('#OldPassword').val().trim() != "") {
                var oldPassword = $('#OldPassword').val().trim();
                $.ajax({
                    type: "POST",
                    url: "/FrontEnd/CheckOldPassword",
                    data: { oldPassword: oldPassword },
                    async: false,
                    success: function (data) {
                        debugger;
                        if (data.isSuccess == 1) {
                            $("span[id='span_OldPassword']").text("Old Password is required.");
                            //return true;
                            $.ajax({
                                type: "POST",
                                url: "/FrontEnd/ChangePassword",
                                async: false,
                                data: { NewPassword: $('#NewPassword').val() },
                                success: function () {
                                    swal(
                                        'Password Changed Successfully.',
                                        '',
                                        'success'
                                    ).then(function () {
                                        window.location.reload();
                                    });
                                },
                                error: function (e) {
                                    alert(e);
                                }
                            });
                        }
                        else {
                            $("span[id='span_OldPassword']").text("Old Password is wrong.");
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

    });
});


function ValidateForm() {

    var isValid = true;


    if ($("#OldPassword").val().trim().length == 0) {
        $("span[id='span_OldPassword']").show();
        isValid = false;

    }
    else {
        $("span[id='span_OldPassword']").hide();
    }


    if ($("#NewPassword").val().trim().length == 0) {
        $("span[id='span_NewPassword']").show();
        isValid = false;
    }
    else {
        $("span[id='span_NewPassword']").hide();
    }


    if ($("#Confirmassword").val().trim().length == 0) {
        $("span[id='span_ConfirmPassword']").show();
        isValid = false;

    }
    else {
        $("span[id='span_ConfirmPassword']").hide();
    }

    if ($("#NewPassword").val().trim().length > 0 && $("#Confirmassword").val().trim().length > 0) {
        if ($("#NewPassword").val().trim() != $("#Confirmassword").val().trim()) {
            $("span[id='span_Confirmassword']").show();
            $("span[id='span_Confirmassword']").html("New Password and Confirm Password are not same");
            isValid = false;

        }
        else {
            $("span[id='span_Confirmassword']").hide();
            $("span[id='span_Confirmassword']").html("Confirm Password is required");
        }

    }


    return isValid;
}

// retunr date into MM/DD/YYYY
function getFormattedDate() {
    var date = new Date();
    var year = date.getFullYear();

    var month = (1 + date.getMonth()).toString();
    month = month.length > 1 ? month : '0' + month;

    var day = date.getDate().toString();
    day = day.length > 1 ? day : '0' + day;

    return month + '/' + day + '/' + year;
}
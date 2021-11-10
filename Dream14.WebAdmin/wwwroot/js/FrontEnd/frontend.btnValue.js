$(document).ready(function () {
    GetUserBetButtonValue();

    $('#btnUpdate').click(function () {
        alert("tested");

        var btnValueList = {};

        btnValueList.Button1 = $('#btn1lbl').val() + ":" + $('#btn1Value').val()
        btnValueList.Button2 = $('#btn2lbl').val() + ":" + $('#btn2Value').val()
        btnValueList.Button3 = $('#btn3lbl').val() + ":" + $('#btn3Value').val()
        btnValueList.Button4 = $('#btn4lbl').val() + ":" + $('#btn4Value').val()
        btnValueList.Button5 = $('#btn5lbl').val() + ":" + $('#btn5Value').val()
        btnValueList.Button6 = $('#btn6lbl').val() + ":" + $('#btn6Value').val()
        btnValueList.Button7 = $('#btn7lbl').val() + ":" + $('#btn7Value').val()
        btnValueList.Button8 = $('#btn8lbl').val() + ":" + $('#btn8Value').val()
        btnValueList.Button9 = $('#btn9lbl').val() + ":" + $('#btn9Value').val()
        btnValueList.Button10 = $('#btn10lbl').val() + ":" + $('#btn10Value').val()

        $.ajax({
            type: "POST",
            url: "/FrontEnd/UpdateBetButtonValue",
            data: { btnValueList: btnValueList },
            success: function () {
                debugger;
                alert("Updated Successfully");
            },
            error: function (e) {
                onFailed(e);
                return false;
            }
        });
    });
});

function GetUserBetButtonValue() {

    $.ajax({
        type: "POST",
        url: "/FrontEnd/GetUserBetButtonValue",
        success: function (btnValueList) {
            if (btnValueList != null && btnValueList != undefined && btnValueList != "") {

                $('#btn1lbl').val(btnValueList["Button1"].split(":")[0]);
                $('#btn1Value').val(btnValueList["Button1"].split(":")[1]);

                $('#btn2lbl').val(btnValueList["Button2"].split(":")[0]);
                $('#btn2Value').val(btnValueList["Button2"].split(":")[1]);

                $('#btn3lbl').val(btnValueList["Button3"].split(":")[0]);
                $('#btn3Value').val(btnValueList["Button3"].split(":")[1]);

                $('#btn4lbl').val(btnValueList["Button4"].split(":")[0]);
                $('#btn4Value').val(btnValueList["Button4"].split(":")[1]);

                $('#btn5lbl').val(btnValueList["Button5"].split(":")[0]);
                $('#btn5Value').val(btnValueList["Button5"].split(":")[1]);

                $('#btn6lbl').val(btnValueList["Button6"].split(":")[0]);
                $('#btn6Value').val(btnValueList["Button6"].split(":")[1]);

                $('#btn7lbl').val(btnValueList["Button7"].split(":")[0]);
                $('#btn7Value').val(btnValueList["Button7"].split(":")[1]);

                $('#btn8lbl').val(btnValueList["Button8"].split(":")[0]);
                $('#btn8Value').val(btnValueList["Button8"].split(":")[1]);

                $('#btn9lbl').val(btnValueList["Button9"].split(":")[0]);
                $('#btn9Value').val(btnValueList["Button9"].split(":")[1]);

                $('#btn10lbl').val(btnValueList["Button10"].split(":")[0]);
                $('#btn10Value').val(btnValueList["Button10"].split(":")[1]);

               
            }
        },
        error: function (e) {
            onFailed(e);
            return false;
        }
    });
}

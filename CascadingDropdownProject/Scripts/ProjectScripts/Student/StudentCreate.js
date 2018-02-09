$("#LoadDepartmentList").click(function () {


    $.ajax({
        type: "POST",
        url: "/Students/GetDepartments",
        data: JSON.stringify(),
        success: function (rData) {
            if (rData != undefined && rData != "") {

                $("#DepartmentId").empty();
                $("#DepartmentId").append("<option value=''>---Select---</option>");


                $.each(rData, function (k, v) {

                    $("#DepartmentId").append("<option value=" + v.Id + ">" + v.Name + "</option>");

                });

            }

        }


    });

});


$("#DepartmentId").change(function () {

    var departmentId = $("#DepartmentId option:selected ").val();
    var departmentId = $(this).val();
    if (departmentId != undefined && departmentId != "") {
        var url = "/Students/GetStudentsByDepartmentId";
        var params = { id: departmentId };
        $.post(url, params, function (data) {
            $("#StudentId").empty();
            $("#StudentId").append('<option value=""> ---Select----</option>');
            $.each(data, function (key, value) {
                $("#StudentId").append("<option value=" + value.Id + ">" + value.Name + "</option>");
            });
        });

    }
});
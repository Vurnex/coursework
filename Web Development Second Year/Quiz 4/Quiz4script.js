function getDate(){

    var jsDate = $('#my_date_picker').datepicker('getDate');

    $("#Table").append("<tr><td>"+jsDate+"</td></tr>");
}
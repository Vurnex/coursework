function addItemToList(){

    var newItem = document.getElementById("itemsBox").value;

    $("#dropDownList").append("<option>"+newItem+"</option>");
}

function changeStyles(){

    $("#itemsBox").css("border", "3px solid", "border-style", "dashed", "border-color", "red");
    $("#itemsBox").css("border-style", "dashed", "border-color", "red");
    $("#itemsBox").css("border-color", "red");

    $("body").css("background-color", "green");

}
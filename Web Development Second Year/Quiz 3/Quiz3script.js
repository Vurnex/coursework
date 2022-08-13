function turnTextRed(){

    $("#TopLabel").css('color', 'red');
}

function centerText(){

    $('th, td').css('text-align', 'center');
}

function addBorders(){

    $('Table').css('border', '1px solid #000');
    $('th, td').css('border', '1px solid #000', 'width', '200px');

}

function removeBorders(){

    $('Table').css('border', 'none');
    $('th, td').css('border', 'none');

}

function inputData(){

    let newData = document.getElementById("TableInput").value;
    alert("Entered: " + newData)

    $("#Table").append("<tr><td>"+newData+"</td></tr>");

}
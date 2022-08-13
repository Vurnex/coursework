var finalGrade = 0;
var chosenAssessment = 0;

function getAssessment(){
    
    chosenAssessment = $("#assignments :selected").text();
    //determine the category. calculate averages and apply weights. send the weighted
    //grade to a function to get the final grade.

    if (chosenAssessment == "Lab") {

        //alert("You have chosen: " + chosenAssessment);

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'block');
        $('#Grade3').css('display', 'block');
        $('#Grade4').css('display', 'block');
        $('#Grade5').css('display', 'block');
        $('#Grade6').css('display', 'block');
        $('#Grade7').css('display', 'block');
        $('#Grade8').css('display', 'block');
        $('#Grade9').css('display', 'block');
        $('#Grade10').css('display', 'block');
        $('#Grade11').css('display', 'none');
        $('#Grade12').css('display', 'none');
        $('#Grade13').css('display', 'none');
        $('#Grade14').css('display', 'none');
        $('#Grade15').css('display', 'none');

    }
    else if (chosenAssessment == "Quiz"){

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'block');
        $('#Grade3').css('display', 'block');
        $('#Grade4').css('display', 'block');
        $('#Grade5').css('display', 'block');
        $('#Grade6').css('display', 'block');
        $('#Grade7').css('display', 'block');
        $('#Grade8').css('display', 'block');
        $('#Grade9').css('display', 'block');
        $('#Grade10').css('display', 'block');
        $('#Grade11').css('display', 'none');
        $('#Grade12').css('display', 'none');
        $('#Grade13').css('display', 'none');
        $('#Grade14').css('display', 'none');
        $('#Grade15').css('display', 'none');

    }
    else if(chosenAssessment == "Exam"){

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'block');
        $('#Grade3').css('display', 'none');
        $('#Grade4').css('display', 'none');
        $('#Grade5').css('display', 'none');
        $('#Grade6').css('display', 'none');
        $('#Grade7').css('display', 'none');
        $('#Grade8').css('display', 'none');
        $('#Grade9').css('display', 'none');
        $('#Grade10').css('display', 'none');
        $('#Grade11').css('display', 'none');
        $('#Grade12').css('display', 'none');
        $('#Grade13').css('display', 'none');
        $('#Grade14').css('display', 'none');
        $('#Grade15').css('display', 'none');

    }
    else if(chosenAssessment == "Participation") {

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'block');
        $('#Grade3').css('display', 'block');
        $('#Grade4').css('display', 'block');
        $('#Grade5').css('display', 'block');
        $('#Grade6').css('display', 'block');
        $('#Grade7').css('display', 'block');
        $('#Grade8').css('display', 'block');
        $('#Grade9').css('display', 'block');
        $('#Grade10').css('display', 'block');
        $('#Grade11').css('display', 'block');
        $('#Grade12').css('display', 'block');
        $('#Grade13').css('display', 'block');
        $('#Grade14').css('display', 'block');
        $('#Grade15').css('display', 'block');

    }
    else if(chosenAssessment == "Project") {

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'none');
        $('#Grade3').css('display', 'none');
        $('#Grade4').css('display', 'none');
        $('#Grade5').css('display', 'none');
        $('#Grade6').css('display', 'none');
        $('#Grade7').css('display', 'none');
        $('#Grade8').css('display', 'none');
        $('#Grade9').css('display', 'none');
        $('#Grade10').css('display', 'none');
        $('#Grade11').css('display', 'none');
        $('#Grade12').css('display', 'none');
        $('#Grade13').css('display', 'none');
        $('#Grade14').css('display', 'none');
        $('#Grade15').css('display', 'none');

    }
    else if(chosenAssessment == "Extra Credit") {

        $('#Grade1').css('display', 'block');
        $('#Grade2').css('display', 'none');
        $('#Grade3').css('display', 'none');
        $('#Grade4').css('display', 'none');
        $('#Grade5').css('display', 'none');
        $('#Grade6').css('display', 'none');
        $('#Grade7').css('display', 'none');
        $('#Grade8').css('display', 'none');
        $('#Grade9').css('display', 'none');
        $('#Grade10').css('display', 'none');
        $('#Grade11').css('display', 'none');
        $('#Grade12').css('display', 'none');
        $('#Grade13').css('display', 'none');
        $('#Grade14').css('display', 'none');
        $('#Grade15').css('display', 'none');

    }

}

function inputData(){

    //let chosenAssessment = document.getElementById("assignments").value;
    //alert("Chosen category: " + chosenAssessment);

    var grade1 = document.getElementById("Grade1").value;

    var grade2 = document.getElementById("Grade2").value;

    var grade3 = document.getElementById("Grade3").value;

    var grade4 = document.getElementById("Grade4").value;

    var grade5 = document.getElementById("Grade5").value;

    var grade6 = document.getElementById("Grade6").value;

    var grade7 = document.getElementById("Grade7").value;

    var grade8 = document.getElementById("Grade8").value;

    var grade9 = document.getElementById("Grade9").value;

    var grade10 = document.getElementById("Grade10").value;

    var grade11 = document.getElementById("Grade11").value;

    var grade12 = document.getElementById("Grade12").value;

    var grade13 = document.getElementById("Grade13").value;

    var grade14 = document.getElementById("Grade14").value;

    var grade15 = document.getElementById("Grade15").value;

    //initialize weights
    var labWeight = 0.30;
    var quizWeight = 0.10;
    var examWeight = 0.30;
    var projectWeight = 0.20;
    var exCreditWeight = 0.05;
    var participationWeight = 0.10;

    //determine the category. calculate averages and apply weights. send the weighted
    //grade to a function to get the final grade.

    if (chosenAssessment == "Lab") {

        var labAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10);

        labAverage = labAverage / 10;

        var labWeighted = labAverage * labWeight;

        getFinalGrade(labWeighted);

    }
    else if (chosenAssessment == "Quiz"){

        var quizAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10);

        quizAverage = quizAverage / 10;
        var quizWeighted = quizAverage * quizWeight;

        getFinalGrade(quizWeighted);
    }
    else if(chosenAssessment == "Exam"){

        var examAverage = parseFloat(grade1) + parseFloat(grade2)

        examAverage = examAverage / 2;
        var examWeighted = examAverage * examWeight;

        getFinalGrade(examWeighted);
  
    }
    else if(chosenAssessment == "Participation") {

        var participAverage = parseFloat(grade1) + parseFloat(grade2) + parseFloat(grade3) 
        + parseFloat(grade4) + parseFloat(grade5) + parseFloat(grade6) + parseFloat(grade7) 
        + parseFloat(grade8) + parseFloat(grade9) + parseFloat(grade10); + parseFloat(grade11);
        + parseFloat(grade12); + parseFloat(grade13); + parseFloat(grade14); + parseFloat(grade15);

        participAverage = participAverage / 15;
        var participationWeighted = participAverage * participationWeight;

        getFinalGrade(participationWeighted);

    }
    else if(chosenAssessment == "Project") {

        var projectAverage = parseFloat(grade1);
        var projectWeighted = projectAverage * projectWeight;

        getFinalGrade(projectWeighted);
    }
    else if(chosenAssessment == "Extra Credit") {

        var exCreditAverage = parseFloat(grade1);
        var exCreditWeighted = exCreditAverage * exCreditWeight;
        getFinalGrade(exCreditWeighted);
    }
    
}

function getFinalGrade(weightedGrade) {

    finalGrade = finalGrade + weightedGrade;
    
    document.getElementById("final").innerHTML = finalGrade;

    if(finalGrade >= 90)
    {
        document.getElementById("letter").innerHTML = "A";
    }
    else if(finalGrade >= 80)
    {
        document.getElementById("letter").innerHTML = "B";
    }
    else if(finalGrade >= 70)
    {
        document.getElementById("letter").innerHTML = "C";
    }
    else if(finalGrade >= 60)
    {
        document.getElementById("letter").innerHTML = "D";
    }
    else if(finalGrade < 60)
    {
        document.getElementById("letter").innerHTML = "F";
    }

}

function clearForm() {

    var frm = document.getElementsByName('input-form')[0];

    frm.reset();  // Reset form fields

    alert("Cleared")

    return false; // Prevent page refresh
}

function redirectPage(weightedGrade) {

    if(finalGrade >= 90)
    {
        alert("Your grade is an A. Excellent work. The page will redirect in 5 seconds.")
        setTimeout(function(){
            window.location.href = 'https://www.google.com/';
         }, 5000); //redirect after 5 seconds
    }
    else if(finalGrade >= 80)
    {
        location.href = "gradeBPage.html";
    }
    else if(finalGrade >= 70)
    {
        location.href = "gradeCPage.html";
    }
    else if(finalGrade >= 60)
    {
        location.href = "gradeDPage.html";
    }
    else if(finalGrade < 60)
    {
        location.href = "gradeFPage.html";
    }

}

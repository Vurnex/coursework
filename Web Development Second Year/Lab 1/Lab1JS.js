var finalGrade = 0;

function inputData(){

    //get data

    let chosenAssessment = document.getElementById("Assessment").value;
    alert("Chosen category: " + chosenAssessment);

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

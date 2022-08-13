<?php

session_start();

if($_POST["lastName"] != "" && $_POST["firstName"] != "" && $_POST["dateBirth"] != "")  {

    $lastName = $_POST["lastName"];
    $StudentID = intval($_POST["StudentID"]);
    $firstName = $_POST["firstName"];
    $dateBirth = $_POST["dateBirth"];
}
else
{
    echo "Please enter some data first.";

    exit();
}

$dsn = "mysql:host=localhost;dbname=StudentList";
$username = "root";
$password = "";

try {

    $db = new PDO($dsn, $username, $password);

    echo "Database connection established.";

    //construct a SELECT statement and execute it by using the query() method of the PDO object.
    $sql = "INSERT INTO student (StudentID, LastName, FirstName, DateOfBirth) 
    VALUES ('$StudentID', '$lastName', '$firstName', '$dateBirth')";

    $q = $db->query($sql);

    //The PDO::FETCH_ASSOC mode instructs the fetch() method to return a result set as an array indexed by column name.
    $q->setFetchMode(PDO::FETCH_ASSOC);

}
catch(PDOException $e) {

    header("Location: problem1ErrorPage.php");

}

?>

<!DOCTYPE html>

<html>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <script src="problem2Script.js"></script>

        <link rel="stylesheet" href="problem1styles.css">

        <title>ITS-362 Final Exam Problem 2</title>

    </head>

    <body>
        <div id="container">

            <h1>Update successful.</h1>

            <?php if ($_SESSION['username'] == 'testuser'): ?>

                <form method="POST" action="problem3userhome.php">
                    <input type="submit" value="Return to Table" id="button1"/>
                </form>

            <?php elseif ($_SESSION['username'] == 'admin'): ?>

                <form method="POST" action="problem3adminhome.php">
                    <input type="submit" value="Return to Table" id="button1"/>
                </form>

            <?php else: ?>

                <form method="POST" action="problem2.php">
                    <input type="submit" value="Return to Table" id="button1"/>
                </form>
            
            <?php endif ?>
            

        </div>
    </body>


</html>
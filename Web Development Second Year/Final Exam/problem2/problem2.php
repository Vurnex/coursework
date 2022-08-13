<?php

$dsn = "mysql:host=localhost;dbname=StudentList";
$username = "root";
$password = "";

try {

    $db = new PDO($dsn, $username, $password);

    echo "Database connection established.";

    //construct a SELECT statement and execute it by using the query() method of the PDO object.
    $sql = 'SELECT StudentID, LastName, FirstName, DateOfBirth
    FROM student';

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
        <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>

        <link rel="stylesheet" href="problem1styles.css">

        <title>ITS-362 Final Exam Problem 2</title>

    </head>

    <body>
        <div id="container">

            <h1>Students</h1>

            <table>

                <thead>

                    <tr>
                        <th>Student ID</th>
                        <th>Last Name</th>
                        <th>First Name</th>
                        <th>Date Of Birth</th>
                        <th>Age</th>
                    </tr>

                </thead>

                <tbody>

                    <?php while ($row = $q->fetch()): ?>

                        <?php
                            $dateOfBirth = $row['DateOfBirth'];
                            $today = date("Y-m-d");
                            $diff = date_diff(date_create($dateOfBirth), date_create($today));
                        ?>


                        <tr>
                            <td><?php echo htmlspecialchars($row['StudentID']) ?></td>
                            <td><?php echo htmlspecialchars($row['LastName']); ?></td>
                            <td><?php echo htmlspecialchars($row['FirstName']); ?></td>
                            <td><?php echo htmlspecialchars($row['DateOfBirth']); ?></td>
                            <td><?php echo $diff->format('%y'); ?></td>
                        </tr>

                    <?php endwhile; ?>

                </tbody>

            </table>

            <br> <button onclick="showItems()">Add Last Name</button>

            <br>
            <form method="POST" action="problem2update.php">
                <label class="display">Enter a new last name: </label>
                <input type="text" id="button1" name="lastName" class="display"/> <br><br>

                <label class="display">Enter the next StudentID: </label>
                <input type="text" id="button2" name="StudentID" class="display"/> <br><br>

                <label class="display">Enter the first name initial (Ex: M.): </label>
                <input type="text" id="button3" name="firstName" class="display"/> <br><br>

                <label class="display">Enter the Date of Birth (M/DD/YYYY): </label>
                <input type="text" id="button4" name="dateBirth" class="display"/> <br><br>

                <input type="submit" value="Submit" id="button1" class="display"/>
            </form>

        </div>
    </body>


</html>
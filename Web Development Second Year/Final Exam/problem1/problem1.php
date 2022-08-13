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

        <!--script src="Lab7script.js"></script-->

        <link rel="stylesheet" href="problem1styles.css">

        <title>ITS-362 Final Exam Problem 1</title>

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

            <form method="POST" action="problem1query2.php">
                <input type="submit" value="Query Smith only" id="button1"/>
            </form>
    </body>
        </div>

</html>
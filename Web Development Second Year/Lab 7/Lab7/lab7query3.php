<?php

$dsn = "mysql:host=localhost;dbname=lab7_database";
$username = "lab7user";
$password = "lab7pass";

try {

    $db = new PDO($dsn, $username, $password);

    echo "Database connection established.";

    //construct a SELECT statement and execute it by using the query() method of the PDO object.
    $sql = 'SELECT FirstName, LastName, Age, CurrentYear, Major 
    FROM students
    WHERE Age > 21
    ORDER BY FirstName';

    $q = $db->query($sql);

    //The PDO::FETCH_ASSOC mode instructs the fetch() method to return a result set as an array indexed by column name.
    $q->setFetchMode(PDO::FETCH_ASSOC);

}
catch(PDOException $e) {

    header("Location: lab7ErrorPage.php");
}

?>

<!DOCTYPE html>

<html>

    <head>

        <meta charset="UTF-8">

        <meta name="viewport" content="width=device-width, initial-scale=1.0">

        <!--script src="Lab7script.js"></script-->

        <link rel="stylesheet" href="Lab7styles.css">

        <title>ITS-362 Lab 7</title>

    </head>

    <body>
        <div id="container">

            <h1>Students (Ages > 21) </h1>

            <table>

                <thead>

                    <tr>
                        <th>First Name</th>
                        <th>Last Name</th>
                        <th>Age</th>
                        <th>CurrentYear</th>
                        <th>Major</th>
                    </tr>

                </thead>

                <tbody>

                    <?php while ($row = $q->fetch()): ?>

                        <tr>
                            <td><?php echo htmlspecialchars($row['FirstName']) ?></td>
                            <td><?php echo htmlspecialchars($row['LastName']); ?></td>
                            <td><?php echo htmlspecialchars($row['Age']); ?></td>
                            <td><?php echo htmlspecialchars($row['CurrentYear']); ?></td>
                            <td><?php echo htmlspecialchars($row['Major']); ?></td>
                        </tr>

                    <?php endwhile; ?>

                </tbody>

            </table>

            <form method="POST" action="lab7query2.php" id="button1">

                <input type="submit" value="Ages < 23"/>

            </form>

            <form method="POST" action="lab7query.php">

                <input type="submit" value="Load all data"/>
                
            </form>

            
    </body>
        </div>

</html>

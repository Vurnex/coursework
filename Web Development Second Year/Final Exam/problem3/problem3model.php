<?php

$dsn = "mysql:host=localhost;dbname=StudentList";
$username = "root";
$password = "";

try {

    $db = new PDO($dsn, $username, $password);

    //echo "Database connection established.";

    //construct a SELECT statement and execute it by using the query() method of the PDO object.
    $sql = 'SELECT username, password
    FROM user';

    $q = $db->query($sql);

    //The PDO::FETCH_ASSOC mode instructs the fetch() method to return a result set as an array indexed by column name.
    $q->setFetchMode(PDO::FETCH_ASSOC);


    $sql2 = 'SELECT username, password
    FROM administrator';

    $q2 = $db->query($sql2);

    //The PDO::FETCH_ASSOC mode instructs the fetch() method to return a result set as an array indexed by column name.
    $q2->setFetchMode(PDO::FETCH_ASSOC);

}
catch(PDOException $e) {

    header("Location: problem1ErrorPage.php");

}

while ($row = $q->fetch()) {

    $userUsername = $row['username'];
    $userPassword = $row['password'];

}

while ($row2 = $q2->fetch()) {

    $adminUsername = $row2['username'];
    $adminPassword = $row2['password'];

}

?>
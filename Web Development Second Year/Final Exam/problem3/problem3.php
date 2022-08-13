<?php
   ob_start();
   session_start();

   include 'problem3model.php';
?>

<html lang = "en">
   
   <head>
      <title>Problem 3</title>
      
   </head>
	
   <body>
      
      <h2>Enter Username and Password</h2>
      <div class = "container form-signin">
         
         <?php
            $msg = '';
            
            if (isset($_POST['login']) && !empty($_POST['username']) 
               && !empty($_POST['password'])) {
				
               if ($_POST['username'] == $userUsername && 
                  $_POST['password'] == $userPassword) {
                  $_SESSION['valid'] = true;
                  $_SESSION['timeout'] = time();
                  $_SESSION['username'] = $userUsername;

                  header("Location: http://localhost/problem3userhome.php");
                  
               }
               else if ($_POST['username'] == $adminUsername && 
               $_POST['password'] == $adminPassword) {
               $_SESSION['valid'] = true;
               $_SESSION['timeout'] = time();
               $_SESSION['username'] = $adminUsername;

               header("Location: http://localhost/problem3adminhome.php");
               
            }
               else {
                  $msg = 'Either the username or password is incorrect or the fields were left empty. ';
               }
            }
         ?>
      </div>
      
      <div>
      
         <form action = "" method = "post">
            <p><?php echo $msg; ?></p>
            <input type = "text" name = "username" placeholder = "username" required autofocus></br> <br>
            <input type = "password" name = "password" placeholder = "password" required> <br> <br>
            
            <button class = "btn btn-lg btn-primary btn-block" type = "submit" name = "login">Login</button>
         </form>
         
      </div> 
      
   </body>
</html>
<!DOCTYPE html>
<html>
  <head>
    <meta charset="utf-8">
    <title>Reverse a String</title>
  </head>
  <body>
    <form method="post" action="reverse-a-string.php">
      <input type="text" name="text" placeholder="Enter some text in this textbox and press the button to have it reversed" style="width: 100%;">
      <input type="submit">
    </form>
    <?php
      if (isset($_POST['text'])) {
        // The strrev() function in PHP reverses any given text. To make this
        // project, one could also apply a simple for-loop counting backwards
        // from the length of the string and output a single char at the time.
        echo '<p>Reversed Text: <strong>' . strrev($_POST['text']) . '</strong></p>';
      }
    ?>
  </body>
</html>

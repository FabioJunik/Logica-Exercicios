<?php

    $extensionNumbers = ["zero","um","dois","três","quatro",
                        "cinco","sex","sete","oito","nove"];
    $output = "";
    $input = ' ';
    
    if(isset($_POST['numero']) && isset($_POST['executar'])){
        
        $input = strval($_POST['numero']);

        for($i=0; $i<strlen($input); $i++){
            $index = intval($input[$i]);
            $output .= $extensionNumbers[$index] . ", ";
        }
        
    }
?>
<!DOCTYPE html>
<html lang="pt-BR">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercio 1</title>
    <link rel="stylesheet" href="./styles.css">
</head>
<body>

    <div class="container">
        <h1 class="titulo">Digitos por extenso</h1>
        <form method='POST' action='' class="box">
                <input type="number" name="numero" placeholder="Digiite um número" value="<?php echo $input;?>">
                <input type="text" name="resultado" placeholder="Resultado" value="<?php echo $output; ?>">
                <input type="submit" name="executar"  value="Executar"/>
        </form>

    </div>

    <script src="assets/js/script.js"></script>
</body>
</html>
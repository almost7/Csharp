<?php
    /*for($i=1;$i<11;$i++){
        echo "$i ";
    }
    echo"<br>";
    for($i=0;$i<21;$i++){
        echo "<ul> <li>$i</li> </ul>";
    }
    echo"<br>";
    for($i=0;$i<101;$i+=2){
        echo "$i ";
    }
    echo"<br>";
    echo"<br>";
    $b=6;
    for($i=1;$i<11;$i++){
        echo "$b x $i = ".$i*$b;
        echo"<br>";
    }
    echo"<br>";
    for($n=1;$n<100;$n++){
        $a=0;
        for($i=1;$i<($n+1);$i++){
            if($n%$i==0){
                $a++;
            }
        }
        if($a==2){    
            echo "$n  ";
        }
    }
    echo"<br>";
    $cont = 0;
    while($cont<100){
        for($n=1;$cont<100;$n++){
            $a=0;
            for($i=1;$i<($n+1);$i++){
                if($n%$i==0){
                    $a++;
                }
            }
            if($a==2){    
                echo "$n  ";
                $cont++;
            }
        }
    }*/
    echo"<br>";
    echo"<br>";
    $pal = "ABC";
    $inv = "";
    for($i=0;$i<3;$i++)
    {
        $inv = $pal[$i].$inv;
    }    
    if (!strcmp($pal,$inv))
    {
        echo "é palindromo";
    }
    else
    {    
        echo "não é palindromo";
    }
    /*$palindromo = "pap";
    if (strrev($palindromo) == $palindromo){   
        echo"a palavra $palindromo é um palindromo";
    }
    else{
        echo"a palavra $palindromo não é um palindromo";
    }*/
    echo"<br>";
    echo"<br>";
    $num = 121;
    $inv = 0;
    $original = $num;
    while($num != 0){
        $resto = $num % 10;
        $num = (int)($num / 10);
        $inv= $inv * 10 + $resto;
    }
    if ($original==$inv)
        echo "é capicua";
    else
        echo "não é capicua";
    /*$capicua = "olo";
    if (strrev($capicua) == $capicua){   
        if(is_integer($capicua)){
            echo"o número $capicua é uma capicua";
        }
        else{
            echo"\"$capicua\" não é capicua";
        }
    }
    else{
        echo"\"$capicua\" não é capicua";
    }*/
    echo"<br>";
    echo"<br>";
?>  
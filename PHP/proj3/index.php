<?php
    function capicua(int $num) : bool{
        $num = 121;
        $inv = 0;
        $original = $num;
        while($num != 0){
            $resto = $num % 10;
            $num = (int)($num / 10);
            $inv= $inv * 10 + $resto;
        }
        return $original!=$inv;
    }
?>